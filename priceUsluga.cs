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
    public partial class priceUsluga : Form
        
        
       
    {
        editData editData = new editData();
        int idClientUsluga;
        public priceUsluga()
        {
            InitializeComponent();
        }

        private void priceUsluga_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.price_usluga". При необходимости она может быть перемещена или удалена.
            this.price_uslugaTableAdapter.Fill(this.uchetDataSet.price_usluga);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.price_usluga". При необходимости она может быть перемещена или удалена.
            this.price_uslugaTableAdapter.Fill(this.uchetDataSet.price_usluga);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.price_usluga". При необходимости она может быть перемещена или удалена.
            this.price_uslugaTableAdapter.Fill(this.uchetDataSet.price_usluga);
            idClientUsluga = editData.idClient;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void saveUsluga_Click(object sender, EventArgs e)
        {
            int inserted = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["checkUsluga"].Value);
                if (isSelected)
                {
                    string constring = @"Data Source=DESKTOP-43BJ3R7\SQLEXPRESS;Initial Catalog=uchet;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(constring))
                    {
                        using (SqlCommand cmd = new SqlCommand(@"INSERT INTO sostavzakaz (name_zak, price_zak, id_usluga, id_client) VALUES(@nameUsl, @priceUsl, @idUsl, @idClient)", con))
                        {
                            cmd.Parameters.AddWithValue("@nameUsl", row.Cells["nameusluga"].Value);
                            cmd.Parameters.AddWithValue("@priceUsl", row.Cells["price"].Value);
                            cmd.Parameters.AddWithValue("@idUsl", row.Cells["id"].Value);
                            cmd.Parameters.Add("@idClient", SqlDbType.Int).Value = idClientUsluga;
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                    inserted++;
                }
            }

            if (inserted > 0)
            {
                MessageBox.Show(string.Format("{0} строк добавлено.", inserted), "Message");
            }
        


        editData.Show();
            this.Close();
        }
    }
}
