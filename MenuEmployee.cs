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
    public partial class MenuEmployee : Form
    {
        public MenuEmployee(Authorization authorization)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EquipmentListEmployee equipmentListEmployee = new EquipmentListEmployee(this);
            equipmentListEmployee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplicationsEmployee applicationsEmployee = new ApplicationsEmployee(this);
            applicationsEmployee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArchiveApplicationsEmployee archiveApplicationsEmployee = new ArchiveApplicationsEmployee(this);
            archiveApplicationsEmployee.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutProgrammEmployee aboutProgrammEmployee = new AboutProgrammEmployee(this);
            aboutProgrammEmployee.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
