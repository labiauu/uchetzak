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
    
    public partial class editData : Form
    {
        public static int idClient;
        int idClientZak;
       


        public editData()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void editData_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet1.sostavzakaz". При необходимости она может быть перемещена или удалена.
            this.sostavzakazTableAdapter.Fill(this.uchetDataSet.sostavzakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.uchetDataSet.zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.statuses". При необходимости она может быть перемещена или удалена.
            this.statusesTableAdapter.Fill(this.uchetDataSet.statuses);
            idClientZak = idClient;
            textBoxId.Text = idClientZak.ToString();
            using (SqlConnection scZak = new SqlConnection())
            {
                scZak.ConnectionString = @"Data Source=DESKTOP-43BJ3R7\SQLEXPRESS;Initial Catalog=uchet;Integrated Security=True";
                scZak.Open();

                using (SqlCommand comZak = new SqlCommand("SELECT * FROM sostavzakaz where id_client = @idClientZak", scZak))
                {
                    
                    comZak.Parameters.Add("@idClientZak", SqlDbType.Int).Value = idClientZak;
                    

                    SqlDataAdapter zakAdapter = new SqlDataAdapter(comZak);
                    DataSet zakDataSet = new DataSet();
                    zakAdapter.Fill(zakDataSet);
                    dataGridView1.DataSource = zakDataSet;

                }
                scZak.Close();

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm mainForm = new mainForm();
            this.Close();
            mainForm.Show();
        }



        public void saveChanges_Click(object sender, EventArgs e)
        {

            int idStatus = Convert.ToInt32(editStatus.SelectedIndex)+1;

            using (SqlConnection sc = new SqlConnection())
            {
                sc.ConnectionString = @"Data Source=DESKTOP-43BJ3R7\SQLEXPRESS;Initial Catalog=uchet;Integrated Security=True";
                sc.Open();

                using (SqlCommand com = sc.CreateCommand())
                {
                    com.CommandText = (@"update clients set name = @clientName, number = @clientNumber, adress = @clientAdress, comment = @clientComment, id_status = @idStatus where id_client = @idClient");

                    
                    com.Parameters.Add("@idClient", SqlDbType.Int).Value = idClient;
                    com.Parameters.Add("@clientName", SqlDbType.NChar, 255).Value = editClient.Text;
                    com.Parameters.Add("@clientNumber", SqlDbType.NChar, 12).Value = editNumber.Text;
                    com.Parameters.Add("@clientAdress", SqlDbType.NChar, 255).Value = editAdress.Text;
                    com.Parameters.Add("@clientComment", SqlDbType.NChar, 255).Value = editComment.Text;
                    com.Parameters.Add("@idStatus", SqlDbType.Int).Value = idStatus;
                    

                    com.ExecuteNonQuery();

                }
                sc.Close();

            }
            this.Close();
            mainForm mainForm = new mainForm();
            mainForm.Show();

        }

        private void btnAddTovar_Click(object sender, EventArgs e)
        {
            priceTovar priceTovar = new priceTovar();
            priceTovar.Show();
            this.Hide();
            
        }

        private void btnAddUsluga_Click(object sender, EventArgs e)
        {
            priceUsluga priceUsluga = new priceUsluga();
            priceUsluga.Show();
            this.Hide();
        }

        

        private void statusesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void editData_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm mainForm = new mainForm();
            this.Close();
            mainForm.Show();
        }
    }
}
