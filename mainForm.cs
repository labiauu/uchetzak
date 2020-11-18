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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace uchetzakazov
{
    public partial class mainForm : Form
    {
        editData editData = new editData();
        orderForm orderForm = new orderForm();
       
        public int idInt;
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
            

        }


        private void mainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet1.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.uchetDataSet1.clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.zakaz". При необходимости она может быть перемещена или удалена.
            //this.zakazTableAdapter.Fill(this.uchetDataSet.zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.statuses". При необходимости она может быть перемещена или удалена.
            this.statusesTableAdapter.Fill(this.uchetDataSet.statuses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.uchetDataSet.clients);
            
            this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Descending);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }

            if (authForm.role == 2)
            {
                menuStrip1.Visible = true;

            }
            else
            {
                menuStrip1.Visible = false;
            }

        }

        public void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string nameClient = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string numberClient = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string adressClient = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string commentClient = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();



                editData.idClient = int.Parse(id);
                editData.editClient.Text = nameClient;
                editData.editNumber.Text = numberClient;
                editData.textBox1.Text = adressClient;
                editData.editComment.Text = commentClient;
                editData.textBoxId.Text = id;
                idInt = int.Parse(id);


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

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers();
            formUsers.Show();
        }

        
        

        

        private void clientBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bsClient = new BindingSource();
            bsClient.DataSource = dataGridView1.DataSource;
            bsClient.Filter = "name Like '%" + clientBox.Text + "%'";
            dataGridView1.DataSource = bsClient;


        }

        private void adressBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bsAdress = new BindingSource();
            bsAdress.DataSource = dataGridView1.DataSource;
            bsAdress.Filter = "adress Like '%" + adressBox.Text + "%'";
            dataGridView1.DataSource = bsAdress;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id_status = comboBox1.SelectedIndex +1;
            BindingSource bsStatus = new BindingSource();
            bsStatus.DataSource = dataGridView1.DataSource;

            bsStatus.Filter = string.Format("Convert(id_status,'System.String') Like '%{0}%'", id_status);
            dataGridView1.DataSource = bsStatus;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog Save = new SaveFileDialog();
                Save.Filter = "PDF (*.pdf)|*.pdf";
                Save.FileName = "отчет_по_клиентам_"+DateTime.Today.ToShortDateString()+".pdf";
                bool valid = false;
                if (Save.ShowDialog() == DialogResult.OK)
                {

                    if (!valid)
                    {

                        

                        PdfPTable data = new PdfPTable(dataGridView1.Columns.Count);
                        
                        data.HorizontalAlignment = Element.ALIGN_CENTER;
                        data.HeaderRows = 1;
                        
                        

                        foreach (DataGridViewColumn column in dataGridView1.Columns)
                        {
                            PdfPCell cell = new PdfPCell(new Phrase(column.DataPropertyName));
                            data.AddCell(cell);
                        }

                        foreach (DataGridViewRow row in dataGridView1.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                data.AddCell(cell.Value.ToString());
                            }
                        }

                        using (FileStream stream = new FileStream(Save.FileName, FileMode.Create))
                        {
                            Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                            PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                            BaseFont baseFont = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

                            pdfDoc.Open();

                           

                            pdfDoc.Add(data);
                            pdfDoc.Close();
                            stream.Close();
                        }

                        MessageBox.Show("Отчет успешно загружен.", "Information");
                    }
                }
            }
        }

        private void datePick_ValueChanged(object sender, EventArgs e)
        {
            BindingSource bsDate = new BindingSource();
            bsDate.DataSource = dataGridView1.DataSource;
            bsDate.Filter = String.Format("Convert(create_date,'System.String') LIKE '%{0}%'", datePick); 
            dataGridView1.DataSource = bsDate;
            

        }

        private void resetFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BindingSource bsFull = new BindingSource();
            bsFull.DataSource = dataGridView1.DataSource;
            bsFull.Filter = null;


            clientBox.Clear();
            adressBox.Clear();
            comboBox1.SelectionLength = 0;
            datePick.Value = DateTime.Today;
        }
    }
}
