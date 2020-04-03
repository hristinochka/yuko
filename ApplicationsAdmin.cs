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
    public partial class ApplicationsAdmin : Form
    {
        private void loadInfoToTable()
        {
            if (dataListView.Items.Count != 0)
            {
                dataListView.Items.Clear();
            }

            List<List<string>> values = DB.loadDataFromApplicationsAdmin();
            foreach (var value in values)
            {
                dataListView.Items.Add(new ListViewItem(new string[] { value[0], value[1], value[2], value[3], value[4], value[5], value[6], value[7] }));
            }
        }
        public ApplicationsAdmin(MenuAdmin menuAdmin)
        {
            InitializeComponent();
            loadInfoToTable();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DB.addDataToApplicationsAdmin(dateTimePicker1.Value, dateTimePicker2.Value);
            loadInfoToTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
