using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Runtime.Remoting;

namespace uchetzakazov
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.uchetDataSet.users);
            if (authForm.role == 2)
            {
                newUser.Enabled = false;
                deleteUser.Enabled = false;
                
            }

        }

        private void newUser_Click(object sender, EventArgs e)
        {
            newUser newUser = new newUser();
            newUser.Show();
            this.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && e.Value != null)
            {
                e.Value = new String('*', e.Value.ToString().Length);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=DESKTOP-43BJ3R7\SQLEXPRESS;Initial Catalog=uchet;Integrated Security=True";

            List<DataGridViewRow> selectedRows = (from row in dataGridView1.Rows.Cast<DataGridViewRow>()
                                                  where Convert.ToBoolean(row.Cells["checkUser"].Value) == true
                                                  select row).ToList();
            if (MessageBox.Show(string.Format("Вы хотите удалить {0} пользователей?", selectedRows.Count), "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        using (SqlCommand cmd = new SqlCommand("DELETE FROM users WHERE id_user = @id_user", con))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@id_user", row.Cells["id_user"].Value);
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            this.dataGridView1.Refresh();
                            this.dataGridView1.Update(); ;
                        }
                    }
                }

                
            }
        }

        private void FormUsers_FormClosing(object sender, FormClosingEventArgs e)
        {
            authForm authForm = new authForm();
            mainForm mainForm = new mainForm();

            if (authForm.role == 1)
            {
                authForm.Show();
            }
            else
                mainForm.Show();
        }
    }
}
