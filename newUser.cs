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
    public partial class newUser : Form
    {
        public newUser()
        {
            InitializeComponent();
        }

        private void newUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.uchetDataSet.role);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int role = Convert.ToInt32(roleBox.SelectedIndex) + 1;
            using (SqlConnection sc = new SqlConnection())
            {
                sc.ConnectionString = @"Data Source=DESKTOP-43BJ3R7\SQLEXPRESS;Initial Catalog=uchet;Integrated Security=True";
                sc.Open();

                using (SqlCommand com = sc.CreateCommand())
                {
                    com.CommandText = (@"insert into users (name, password, id_role) values(@name, @password, @role)");

                    
                    com.Parameters.Add("@name", SqlDbType.NChar, 255).Value = logBox.Text;
                    com.Parameters.Add("@password", SqlDbType.NChar, 12).Value = passBox.Text;
                    com.Parameters.Add("@role", SqlDbType.Int).Value = role;

                    com.ExecuteNonQuery();

                }
                sc.Close();
            }

            
            
            FormUsers FormUsers = new FormUsers();
            FormUsers.dataGridView1.Refresh();
            this.Close();
            FormUsers.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            logBox.Clear();
            passBox.Clear();
            roleBox.SelectedIndex = -1;
        }

        private void newUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormUsers FormUsers = new FormUsers();
            FormUsers.Show();
        }
    }
}
