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
    public partial class ReportEmployee : Form
    {
        private void Prostoy()
        {
            _ = dateTimePicker1.Value - dateTimePicker2.Value;
        }
        private void Filter()
        {
            if (dataListView.Items.Count != 0)
            {
                dataListView.Items.Clear();
            }

            List<List<string>> values = DB.loadDataWithFilter();
            foreach (var value in values)
            {
                dataListView.Items.Add(new ListViewItem(new string[] { value[0], value[1], value[2], value[3], value[4], value[5], value[6], value[7] }));
            }
        }
        public ReportEmployee(ArchiveApplicationsEmployee archiveApplicationsEmployee)
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            EquipmentDowntimeEmployee equipmentDowntimeEmployee = new EquipmentDowntimeEmployee(this);
            equipmentDowntimeEmployee.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
