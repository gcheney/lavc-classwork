using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cheney_895_FinalProject
{
    public partial class Form2 : Form
    {
        private int selectedBase = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                selectedBase = int.Parse(cboBase.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("You must select a base!", "No Base Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboBase.Focus();
                DialogResult = DialogResult.None;
            }
        }

        public int getBase
        {
            get
            {
                return selectedBase;
            }
            set
            {
                if (value < 1)
                    selectedBase = 2;
                else
                    selectedBase = value;
            }
        }
    }
}
