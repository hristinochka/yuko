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
    public partial class AddUsersAdmin : Form
    {
        private void loadInfoToTable()
        {
            if (dataListView.Items.Count != 0)
            {
                dataListView.Items.Clear();
            }

            List<List<string>> values = DB.loadDataFromUsersAdmin();
            foreach (var value in values)
            {
                dataListView.Items.Add(new ListViewItem(new string[] { value[0], value[1], value[2] }));
            }
        }
        private void loadInfoToCombobox1()
        {
            if (comboBox1.Items.Count != 0)
            {
                comboBox1.Items.Clear();
            }

            List<string> values = DB.loadDataFromPositionAdmin();
            foreach (var value in values)
            {
                comboBox1.Items.Add(value.ToString());
            }
        }
        public AddUsersAdmin(MenuAdmin menuAdmin)
        {
            InitializeComponent();
            loadInfoToTable();
            loadInfoToCombobox1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB.addDataToUsersAdmin(textBox1.Text, comboBox1.Text);
            loadInfoToTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
