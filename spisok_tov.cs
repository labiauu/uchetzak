using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uchetzakazov
{
    public partial class spisok_tov : Form
    {
        public spisok_tov()
        {
            InitializeComponent();
        }

        private void spisok_tov_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter.Fill(this.uchetDataSet.zakaz);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.price_usluga". При необходимости она может быть перемещена или удалена.
            this.price_uslugaTableAdapter.Fill(this.uchetDataSet.price_usluga);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.price_tovar". При необходимости она может быть перемещена или удалена.
            this.price_tovarTableAdapter.Fill(this.uchetDataSet.price_tovar);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void spisok_tov_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet1.zakaz". При необходимости она может быть перемещена или удалена.
            this.zakazTableAdapter1.Fill(this.uchetDataSet1.zakaz);
            

        }

        private void addTovar_Click(object sender, EventArgs e)
        {
            priceTovar priceTovar = new priceTovar();
            priceTovar.Show();
        }

        private void addUsluga_Click(object sender, EventArgs e)
        {
            priceUsluga priceUsluga = new priceUsluga();
            priceUsluga.Show();
        }
    }
}
