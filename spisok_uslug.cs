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
    public partial class priceUsluga : Form
    {
        public priceUsluga()
        {
            InitializeComponent();
        }

        private void priceUsluga_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.price_usluga". При необходимости она может быть перемещена или удалена.
            this.price_uslugaTableAdapter.Fill(this.uchetDataSet.price_usluga);

        }
    }
}
