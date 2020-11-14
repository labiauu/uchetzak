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
                mainForm.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Некоректный логин или пароль", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loginbox.Clear();
                passbox.Clear();
            }
        }
    
        

            
            
        }

        
    }

