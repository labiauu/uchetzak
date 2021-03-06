﻿using System;
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
    public partial class priceTovar : Form
    {
        editData editData = new editData();
        int idClientTovar;
        
        public priceTovar()
        {
            InitializeComponent();
        }

        private void priceTovar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.uchetDataSet.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.price_tovar". При необходимости она может быть перемещена или удалена.
            this.price_tovarTableAdapter.Fill(this.uchetDataSet.price_tovar);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.price_tovar". При необходимости она может быть перемещена или удалена.
            this.price_tovarTableAdapter.Fill(this.uchetDataSet.price_tovar);

           
            idClientTovar = editData.idClient;
            //test.Text = idClientText.ToString();
               
        }

        private void addTovar_MouseEnter(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void saveTovar_Click(object sender, EventArgs e)
        {

            {
                int inserted = 0;
                
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["checkTovar"].Value);
                    if (isSelected)
                    {
                        string constring = @"Data Source=DESKTOP-43BJ3R7\SQLEXPRESS;Initial Catalog=uchet;Integrated Security=True";
                        using (SqlConnection con = new SqlConnection(constring))
                        {
                            using (SqlCommand cmd = new SqlCommand(@"INSERT INTO sostavzakaz (name_zak, price_zak ,id_tovar, id_client) VALUES(@nameTov, @priceTov ,@idTov, @idClient)", con))
                            {
                                cmd.Parameters.AddWithValue("@nameTov", row.Cells["nametovar"].Value);
                                cmd.Parameters.AddWithValue("@priceTov", row.Cells["price"].Value);
                                cmd.Parameters.AddWithValue("@idTov", row.Cells["id"].Value);
                                cmd.Parameters.Add("@idClient", SqlDbType.Int).Value = idClientTovar;
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


                editData.dataGridView1.Update();
                editData.dataGridView1.Refresh();
                editData.Show();
                this.Close();
            }
            
        }

        private void priceTovar_FormClosed(object sender, FormClosedEventArgs e)
        {
            editData editData = new editData();
            editData.Show();
        }
    }
}
