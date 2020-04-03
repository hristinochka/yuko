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
    public partial class ApplicationsMaster : Form
    {
        private void loadInfoToTable()
        {
            if (dataListView.Items.Count != 0)
            {
                dataListView.Items.Clear();
            }

            List<List<string>> values = DB.loadDataFromApplicationsMaster();
            foreach (var value in values)
            {
                dataListView.Items.Add(new ListViewItem(new string[] { value[0], value[1], value[2], value[3], value[4], value[5], value[6], value[7] }));
            }
        }
        private void loadInfoToCombobox1()
        {
            if (comboBox1.Items.Count != 0)
            {
                comboBox1.Items.Clear();
            }

            List<string> values = DB.loadDataFromJobStatusMaster();
            foreach (var value in values)
            {
                comboBox1.Items.Add(value.ToString());
            }
        }
        public ApplicationsMaster(MenuMaster menuMaster)
        {
            InitializeComponent();
            loadInfoToTable();
            loadInfoToCombobox1();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectionLength == 0)
            {
                MessageBox.Show("Enter value");
                return;
            }
            DB.addDataToApplicationsMaster(comboBox1.Text, dateTimePicker1.Value, dateTimePicker2.Value);
            loadInfoToTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
