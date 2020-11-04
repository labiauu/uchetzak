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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.uchetDataSet.zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.statuses". При необходимости она может быть перемещена или удалена.
            this.statusesTableAdapter.Fill(this.uchetDataSet.statuses);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void saveChanges_Click(object sender, EventArgs e)
        {
            using (SqlConnection sc = new SqlConnection())
            {
                sc.ConnectionString = @"Data Source=DESKTOP-43BJ3R7\SQLEXPRESS;Initial Catalog=uchet;Integrated Security=True";
                sc.Open();

                using (SqlCommand com = sc.CreateCommand())
                {
                    com.CommandText = (@"insert into clients(name, number, adress, comment, create_date, id_status) values(@clientName, @clientNumber, @clientAdress, @clientComment, @dateTime, @status)");

                    //TODO: Change my arbitrary "80" to actual Stock fields' sizes! 
                    com.Parameters.Add("@clientName", SqlDbType.NChar, 255).Value = clientName.Text;
                    com.Parameters.Add("@clientNumber", SqlDbType.NChar, 12).Value = clientNumber.Text;
                    com.Parameters.Add("@clientAdress", SqlDbType.NChar, 255).Value = clientAdress.Text;
                    com.Parameters.Add("@clientComment", SqlDbType.NChar, 255).Value = clientComment.Text;
                    com.Parameters.Add("@dateTime", SqlDbType.Date).Value = dateTime.Value;
                    com.Parameters.Add("@status", SqlDbType.Int).Value = 1;
                    com.ExecuteNonQuery();

                }
                sc.Close();
            }

        private void btnAddUsluga_Click(object sender, EventArgs e)
        {
            priceUsluga priceUsluga = new priceUsluga();
            priceUsluga.Show();
        }
    }
}
