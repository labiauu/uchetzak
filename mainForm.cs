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
        editData editData = new editData();
        orderForm orderForm = new orderForm();
        reportForm reportForm = new reportForm();
        public mainForm()
        {
            InitializeComponent();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            orderForm.Show();
            this.Close();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            reportForm.Show();
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
            
                if (dataGridView1.CurrentRow != null)
                {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nameClient = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string numberClient = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(); 
                string adressClient = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string commentClient = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                //string statusId = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                //int statusItem = int.Parse(statusId);
                
                
                editData.idClient = int.Parse(id);
                editData.editClient.Text = nameClient;
                editData.editNumber.Text= numberClient;
                editData.textBox1.Text = adressClient;
                editData.editComment.Text = commentClient;
                //editData.editStatus.DisplayMember = statusId;
 
                }
            editData.Show();
            this.Close();
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

       

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
