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
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
           
            

        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            orderForm orderForm = new orderForm();
            orderForm.Show();
            this.Close();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            reportForm reportForm = new reportForm();
            reportForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.uchetDataSet.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.statuses". При необходимости она может быть перемещена или удалена.
            this.statusesTableAdapter.Fill(this.uchetDataSet.statuses);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            editData editData = new editData();
            

                if (dataGridView1.CurrentRow != null)
                {
                string nameClient = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string numberClient = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); 
                string adressClient = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string commentClient = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                editData.editName.Text = nameClient;
                editData.editNumber.Text= numberClient;
                editData.editAdress.Text = adressClient;
                editData.editComment.Text = commentClient;
                editData.Show();


                }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientsTableAdapter.FillBy(this.uchetDataSet.clients);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.clientsTableAdapter.FillBy(this.uchetDataSet.clients);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.clientsTableAdapter.FillBy(this.uchetDataSet.clients);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                this.clientsTableAdapter.FillBy(this.uchetDataSet.clients);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
