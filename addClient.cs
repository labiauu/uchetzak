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
    public partial class orderForm : Form
    {
        public orderForm()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            spisok_tov spisok_Tov = new spisok_tov();
            spisok_Tov.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection sc = new SqlConnection())
            {
                sc.ConnectionString = @"Data Source=DESKTOP-43BJ3R7\SQLEXPRESS;Initial Catalog=uchet;Integrated Security=True";
                sc.Open();

                using (SqlCommand com = sc.CreateCommand())
                {
                    com.CommandText =(@"insert into clients(name, number, adress, comment, create_date, id_status) values(@clientName, @clientNumber, @clientAdress, @clientComment, @dateTime, @status)");

                    //TODO: Change my arbitrary "80" to actual Stock fields' sizes! 
                    com.Parameters.Add("@clientName", SqlDbType.NChar, 255).Value = clientName.Text;
                    com.Parameters.Add("@clientNumber", SqlDbType.NChar, 12).Value = clientNumber.Text;
                    com.Parameters.Add("@clientAdress", SqlDbType.NChar, 255).Value = clientAdress.Text;
                    com.Parameters.Add("@clientComment", SqlDbType.NChar, 255).Value = clientComment.Text;
                    com.Parameters.Add("@dateTime", SqlDbType.Date).Value = dateTime.Value;
                    com.Parameters.Add("@status",SqlDbType.Int).Value = 1;
                    com.ExecuteNonQuery();

                }
                sc.Close();
            }
            
            mainForm mainForm = new mainForm();
            this.Close();
            mainForm.Show();
            mainForm.dataGridView1.Refresh();


        }

        private void orderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.statuses". При необходимости она может быть перемещена или удалена.
            this.statusesTableAdapter.Fill(this.uchetDataSet.statuses);
            clientName.Text = "ФИО клиента/название компании";
            clientName.ForeColor = Color.Gray;
            clientAdress.Text = "Адрес доставки";
            clientAdress.ForeColor = Color.Gray;
            clientComment.Text = "Дополнительная информация";
            clientComment.ForeColor = Color.Gray;
            
        }

        private void clientName_Enter(object sender, EventArgs e)
        {
            if (clientName.Text == "ФИО клиента/название компании")
            {
                clientName.Clear();
                clientName.ForeColor = Color.Black;
            }

        }

        private void clientAdress_Enter(object sender, EventArgs e)
        {
            if (clientAdress.Text == "Адрес доставки")
            {
                clientAdress.Clear();
                clientAdress.ForeColor = Color.Black;
            }
        }

        private void clientComment_Enter(object sender, EventArgs e)
        {
            if (clientComment.Text == "Дополнительная информация")
            {
                clientComment.Clear();
                clientComment.ForeColor = Color.Black;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm mainForm = new mainForm();
            mainForm.Show();
        }
    }
}
