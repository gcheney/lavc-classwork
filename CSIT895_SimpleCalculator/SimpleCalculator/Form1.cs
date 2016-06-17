using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        private double currentNum = 0, total = 0;
        private string displayText;
        private char operation;
        private bool btnWasClicked = false, firstTime = true, equalsWasClicked = false;

        public Form1()
        {
            InitializeComponent();
            resetColor();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (btnWasClicked) 
            {
                resetColor();
                txtDisplay.Text = "";
                displayText = "";
                btnWasClicked = false;
            }
            displayText += btnOne.Text;
            txtDisplay.Text = displayText;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (btnWasClicked)
            {
                txtDisplay.Text = "";
                displayText = "";
                btnWasClicked = false;
            }
            displayText += btnTwo.Text;
            txtDisplay.Text = displayText;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (btnWasClicked)
            {
                txtDisplay.Text = "";
                displayText = "";
                btnWasClicked = false;
            }
            displayText += btnThree.Text;
            txtDisplay.Text = displayText;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (btnWasClicked)
            {
                txtDisplay.Text = "";
                displayText = "";
                btnWasClicked = false;
            }
            displayText += btnFour.Text;
            txtDisplay.Text = displayText;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (btnWasClicked)
            {
                txtDisplay.Text = "";
                displayText = "";
                btnWasClicked = false;
            }
            displayText += btnFive.Text;
            txtDisplay.Text = displayText;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (btnWasClicked)
            {
                txtDisplay.Text = "";
                displayText = "";
                btnWasClicked = false;
            }
            displayText += btnSix.Text;
            txtDisplay.Text = displayText;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (btnWasClicked)
            {
                txtDisplay.Text = "";
                displayText = "";
                btnWasClicked = false;
            }
            displayText += btnSeven.Text;
            txtDisplay.Text = displayText;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (btnWasClicked)
            {
                txtDisplay.Text = "";
                displayText = "";
                btnWasClicked = false;
            }
            displayText += btnEight.Text;
            txtDisplay.Text = displayText;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (btnWasClicked)
            {
                txtDisplay.Text = "";
                displayText = "";
                btnWasClicked = false;
            }
            displayText += btnNine.Text;
            txtDisplay.Text = displayText;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (btnWasClicked)
            {
                txtDisplay.Text = "";
                displayText = "";
                btnWasClicked = false;
            }
            displayText += btnZero.Text;
            txtDisplay.Text = displayText;
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (btnWasClicked)
            {
                txtDisplay.Text = "";
                displayText = "";
                btnWasClicked = false;
            }
            displayText += ".";
            txtDisplay.Text = displayText;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnSelected())
            {
                btnEquals_Click(sender, e);
            }
            resetColor();
            btnAdd.BackColor = Color.Yellow;
            operation = '+';
            if (!equalsWasClicked)
            {
                currentNum = Double.Parse(displayText);
                if (firstTime)
                    total = currentNum;
                else
                    total += currentNum;
            }

            if (!firstTime && !equalsWasClicked)
            {
                txtDisplay.Text = total.ToString();
            }
            else
            {
                equalsWasClicked = false;
            }
            btnWasClicked = true;
            firstTime = false;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (btnSelected())
            {
                btnEquals_Click(sender, e);
            }
            resetColor();
            btnSubtract.BackColor = Color.Yellow;
            operation = '-';
            if (!equalsWasClicked)
            {
                currentNum = Double.Parse(displayText);
                if (firstTime)
                    total = currentNum;
                else
                    total -= currentNum;
            }
            if (!firstTime && !equalsWasClicked)
            {
                txtDisplay.Text = total.ToString();
            }
            else
            {
                equalsWasClicked = false;
            }
            btnWasClicked = true;
            firstTime = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (btnSelected())
            {
                btnEquals_Click(sender, e);
            }
            resetColor();
            btnMultiply.BackColor = Color.Yellow;
            operation = '*';
            if (!equalsWasClicked)
            {
                currentNum = Double.Parse(displayText);
                if (firstTime)
                    total = currentNum;
                else
                    total *= currentNum;
            }
            if (!firstTime && !equalsWasClicked)
            {
                txtDisplay.Text = total.ToString();
            }
            else
            {
                equalsWasClicked = false;
            }
            btnWasClicked = true;
            firstTime = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (btnSelected())
            {
                btnEquals_Click(sender, e);
            }
            resetColor();
            btnDivide.BackColor = Color.Yellow;
            operation = '/';
            if (!equalsWasClicked)
            {
                currentNum = Double.Parse(displayText);
                if (firstTime)
                    total = currentNum;
                else
                    total = total/currentNum;
            }
            if (!firstTime && !equalsWasClicked)
            {
                txtDisplay.Text = total.ToString();
            }
            else
            {
                equalsWasClicked = false;
            }
            btnWasClicked = true;
            firstTime = false;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double lastNum = Double.Parse(displayText);

            if (operation == '+')
                total += lastNum;
            else if (operation == '-')
                total -= lastNum;
            else if (operation == '*')
                total *= lastNum;
            else if (operation == '/')
            {
                if (total == 0)
                    total = currentNum / lastNum;
                else
                    total = total/lastNum;
            }

            txtDisplay.Text = total.ToString();
            btnWasClicked = true;
            equalsWasClicked = true;
            resetColor();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            displayText = "";
            btnWasClicked = false;
            equalsWasClicked = false;
            firstTime = true;
            total = 0;
            currentNum = 0;
            resetColor();
        }

        public void resetColor()
        {
            btnAdd.BackColor = Color.LightBlue;
            btnSubtract.BackColor = Color.LightBlue;
            btnMultiply.BackColor = Color.LightBlue;
            btnDivide.BackColor = Color.LightBlue;
            btnEquals.BackColor = Color.Red;
        }

        public bool btnSelected()
        {
            bool selected = false;

            if(btnSubtract.BackColor == Color.Yellow || btnAdd.BackColor == Color.Yellow
                || btnMultiply.BackColor == Color.Yellow || btnDivide.BackColor == Color.Yellow)
            {
                selected = true;
            }

            return selected;
        }
    }
}
