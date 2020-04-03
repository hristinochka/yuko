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
    public partial class EquipmentListMaster : Form
    {
        private void loadInfoToTable()
        {
            if (dataListView.Items.Count != 0)
            {
                dataListView.Items.Clear();
            }

            List<List<string>> values = DB.loadDataFromEquipmentMaster();
            foreach (var value in values)
            {
                dataListView.Items.Add(new ListViewItem(new string[] { value[0], value[1], value[2], value[3], value[4], value[5], value[6] }));
            }
        }
        private void loadInfoToCombobox1()
        {
            if (comboBox1.Items.Count != 0)
            {
                comboBox1.Items.Clear();
            }

            List<string> values = DB.loadDataFromTypeOfEquipmentMaster();
            foreach (var value in values)
            {
                comboBox1.Items.Add(value.ToString());
            }
        }
        private void loadInfoToCombobox2()
        {
            if (comboBox2.Items.Count != 0)
            {
                comboBox2.Items.Clear();
            }

            List<string> values = DB.loadDataFromNameOfEquipmentMaster();
            foreach (var value in values)
            {
                comboBox2.Items.Add(value.ToString());
            }
        }
        private void loadInfoToCombobox3()
        {
            if (comboBox3.Items.Count != 0)
            {
                comboBox3.Items.Clear();
            }

            List<string> values = DB.loadDataFromApplyingMaster();
            foreach (var value in values)
            {
                comboBox3.Items.Add(value.ToString());
            }
        }
        public EquipmentListMaster(MenuMaster menuMaster)
        {
            InitializeComponent();
            loadInfoToTable();
            loadInfoToCombobox1();
            loadInfoToCombobox2();
            loadInfoToCombobox3();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectionLength == 0 || comboBox2.SelectionLength == 0 || textBox1.TextLength == 0 || textBox2.TextLength == 0 || textBox3.TextLength == 0 || comboBox3.SelectionLength == 0)
            {
                MessageBox.Show("Enter value");
                return;
            }
            DB.addDataToEquipmentMaster(comboBox1.Text, comboBox2.Text, textBox1.Text, textBox2.Text, textBox3.Text, comboBox3.Text);
            loadInfoToTable();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Выберите строчку для удаления.");
            }
            DB.deleteDataFromEquipmentMaster(dataListView.SelectedItems[0].Text);
            loadInfoToTable();
        }
    }
}
