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
    public partial class editUser : Form
    {
        public int idUser;
       
        public editUser()
        {
            InitializeComponent();
        }

        private void editUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.role". При необходимости она может быть перемещена или удалена.
            this.roleTableAdapter.Fill(this.uchetDataSet.role);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            FormUsers FormUsers = new FormUsers();
            FormUsers.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sc = new SqlConnection())
            {
                sc.ConnectionString = @"Data Source=DESKTOP-43BJ3R7\SQLEXPRESS;Initial Catalog=uchet;Integrated Security=True";
                sc.Open();

                using (SqlCommand com = sc.CreateCommand())
                {
                    com.CommandText = (@"update users set name = @username, password = @pass where id_user = @idUser");


                    com.Parameters.Add("@idUser", SqlDbType.Int).Value = idUser;
                    com.Parameters.Add("@username", SqlDbType.NChar, 255).Value = loginText.Text;
                    com.Parameters.Add("@pass", SqlDbType.NChar, 12).Value = passText.Text;
                    
                    com.ExecuteNonQuery();

                }
                sc.Close();

            }
            this.Close();
            FormUsers FormUsers = new FormUsers();
            FormUsers.Show();
        }

        private void editUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormUsers FormUsers = new FormUsers();
            FormUsers.Show();
        }
    }
}
