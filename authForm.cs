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
    public partial class authForm : Form
    {
        public static int role;
        public authForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        

        private void loginButton_Click(object sender, EventArgs e)
        {

            mainForm mainForm = new mainForm();
            FormUsers formUsers = new FormUsers();
            SqlConnection connection = new SqlConnection();
            SqlCommand comand = new SqlCommand();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            DataSet dataset = new DataSet();
            

            connection.ConnectionString = (@"Data Source=DESKTOP-43BJ3R7\SQLEXPRESS;Initial Catalog=uchet;Integrated Security=True");
            comand.CommandText = @"SELECT * FROM users WHERE name='" + loginbox.Text + "'AND password='" + passbox.Text + "';";
            connection.Open();
            

            comand.Connection = connection;
            
            adaptor.SelectCommand = comand;
            adaptor.Fill(dataset, "0");
            int count = dataset.Tables[0].Rows.Count;

            if (count > 0)
            {
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    textBox1.Text = reader["id_role"].ToString();
                    role = int.Parse(textBox1.Text);
                }
                if (role == 1)
                {
                    formUsers.Show();
                    this.Hide();
                }
                else
                {
                    mainForm.Show();
                    this.Hide();
                }
                
            }
            else
            {

                MessageBox.Show("Некоректный логин или пароль", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginbox.Clear();
                passbox.Clear();
            }
        }

        private void authForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Закрыть приложение?", "Message", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;

        }
    }

        
    }

