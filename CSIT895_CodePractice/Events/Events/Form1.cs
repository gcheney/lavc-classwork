using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString() + "\n" + e.ToString());
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                txtMouse.Text = "Left Button Clicked";
            }
            else if (e.Button == MouseButtons.Right)
            {
                txtMouse.Text = "Right Button Clicked";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                MessageBox.Show("Letter A Pressed");
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("You can't leave this box blank");
                textBox1.Focus();
            }
            else
            {
                textBox1.Text = textBox1.Text.ToUpper();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 1)
            {
                loadListBoxCards();
            }
            else if (listBox1.SelectedIndex == 0)
            {
                loadListBoxChecks();
            }
        }

        private void loadListBoxCards()
        {
            listBox2.Items.Clear();

            listBox2.Items.Add("American Express");
            listBox2.Items.Add("MasterCard");
        }

        private void loadListBoxChecks()
        {
            listBox2.Items.Clear();

            listBox2.Items.Add("Business Check");
            listBox2.Items.Add("Personal Check");
        }
    }
}
