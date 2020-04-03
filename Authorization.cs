using System;
using System.Windows.Forms;

namespace Diploma
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            toolTip1.SetToolTip(button1, "Введите логин");
            toolTip1.SetToolTip(button2, "Введите пароль");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text=="admin")
                {
                    MenuAdmin menuAdmin = new MenuAdmin(this);
                    menuAdmin.Show();
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Пароль неверный, попробуйте снова.");
                }
            }
            else if (textBox1.Text == "master")
            {
                if (textBox2.Text == "master")
                {
                    MenuMaster menuMaster = new MenuMaster(this);
                    menuMaster.Show();
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Пароль неверный, попробуйте снова.");
                }
            }
            else if (textBox1.Text == "employee")
            {
                if (textBox2.Text == "employee")
                {
                    MenuEmployee menuEmployee = new MenuEmployee(this);
                    menuEmployee.Show();
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show("Пароль неверный, попробуйте снова.");
                }
            }
            else if (textBox1.TextLength == 0 || textBox2.TextLength == 0)
            {
                MessageBox.Show("Введите значения.");
                return;
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
