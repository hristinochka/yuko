using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma
{
    public partial class EquipmentListAdmin : Form
    {
        public EquipmentListAdmin(MenuAdmin menuAdmin)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddInEqListAdmin addInEqListAdmin = new AddInEqListAdmin(this);
            addInEqListAdmin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
