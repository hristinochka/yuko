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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin(Authorization authorization)
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EquipmentListAdmin equipmentListAdmin = new EquipmentListAdmin(this);
            equipmentListAdmin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddUsersAdmin addUsersAdmin = new AddUsersAdmin(this);
            addUsersAdmin.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApplicationsAdmin applicationsAdmin = new ApplicationsAdmin(this);
            applicationsAdmin.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ArchiveApplicationsAdmin archiveApplicationsAdmin = new ArchiveApplicationsAdmin(this);
            archiveApplicationsAdmin.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AboutProgrammAdmin aboutProgrammAdmin = new AboutProgrammAdmin(this);
            aboutProgrammAdmin.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
