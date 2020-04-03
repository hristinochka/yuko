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
    public partial class AddInEqListAdmin : Form
    {
        public AddInEqListAdmin(EquipmentListAdmin equipmentListAdmin)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTypeOfEquipmentAdmin addTypeOfEquipmentAdmin = new AddTypeOfEquipmentAdmin(this);
            addTypeOfEquipmentAdmin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddNameOfEquipmentAdmin addNameOfEquipmentAdmin = new AddNameOfEquipmentAdmin(this);
            addNameOfEquipmentAdmin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
