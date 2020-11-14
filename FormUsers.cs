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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "uchetDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.uchetDataSet.users);

        }

        private void newUser_Click(object sender, EventArgs e)
        {
            newUser newUser = new newUser();
            newUser.Show();
            this.Close();
        }
    }
}
