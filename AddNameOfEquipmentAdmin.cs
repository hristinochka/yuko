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
    public partial class AddNameOfEquipmentAdmin : Form
    {
        private void loadInfoToTable()
        {
            if (dataListView.Items.Count != 0)
            {
                dataListView.Items.Clear();
            }

            List<List<string>> values = DB.loadDataFromNameOfEquipmentAdmin();
            foreach (var value in values)
            {
                dataListView.Items.Add(new ListViewItem(new string[] { value[0], value[1] }));
            }
        }
        public AddNameOfEquipmentAdmin(AddInEqListAdmin addInEqListAdmin)
        {
            InitializeComponent();
            loadInfoToTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB.addDataToNameOfEquipmentAdmin(textBox1.Text);
            loadInfoToTable();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB.deleteDataFromNameOfEquipmentAdmin(textBox1.Text);
            loadInfoToTable();
            textBox1.Clear();
        }
    }
}
