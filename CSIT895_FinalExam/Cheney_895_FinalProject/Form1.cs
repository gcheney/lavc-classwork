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
    /*
     * Name: Glendon Cheney
     * Class: CSIT 895
     * FInal Exam/Project 
     * All Parts 1-4
     * */

    public partial class Form1 : Form
    {
        private Button[] btnArray;
        private int numButtons = 0, previousNum = 0;
        private int[] clickedButtons = new int[100];
        private int btnIndex = 0;
        private int[] freqArray = new int[10];

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetBase_Click(object sender, EventArgs e)
        {
            int selectedBase;
            Form2 frmDialog = new Form2(); 
            frmDialog.ShowDialog(this);
            if (frmDialog.DialogResult == DialogResult.OK)
            {
                selectedBase = frmDialog.getBase;
                //lblOutDigits.Text = selectedBase.ToString();
                numButtons = selectedBase;
                CreateBaseButtons(numButtons);
                previousNum = numButtons;
            }
        }

        private void CreateBaseButtons(int n)
        {
            int x = 10, y = 10;
            btnArray = new Button[n];

            for (int j = 0; j < n; j++)
            {
                btnArray[j] = new Button();
                btnArray[j].Location = new System.Drawing.Point(x, y);
                btnArray[j].Name = "btn" + j;
                btnArray[j].Size = new System.Drawing.Size(50,23);
                btnArray[j].Text = j.ToString();
                btnArray[j].UseVisualStyleBackColor = true;
                btnArray[j].Click += new System.EventHandler(btnN_Click);
                this.Controls.Add(btnArray[j]);
                x += btnArray[j].Size.Width;
            }
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            string clickedBtn = ((Button)sender).Text;
            int btn = int.Parse(clickedBtn);
            lblOutDigits.Text += clickedBtn;
            clickedButtons[btnIndex] = btn;
            freqArray[btn] += 1;
            btnIndex++;
        }

        private void btnShowFreq_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < numButtons; i++)
                lstFrequencies.Items.Add(i + "\t\t" + freqArray[i]);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int temp = 0;
            for (int i = 0; i < btnIndex; i++) 
            {
                for (int n = i + 1; n < btnIndex; n++) 
                {
                    if (clickedButtons[i] > clickedButtons[n])
                    {
                        temp = clickedButtons[i];
                        clickedButtons[i] = clickedButtons[n];
                        clickedButtons[n] = temp;
                    }
                }
            }

            lblOutDigits.Text = "  ";
            for (int j = 0; j < btnIndex; j++)
                lblOutDigits.Text += clickedButtons[j].ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < previousNum; i++)
                btnArray[i].Dispose();
            lblOutDigits.Text = " ";
            Array.Clear(clickedButtons, 0, clickedButtons.Length);
            btnIndex = 0;
            Array.Clear(freqArray, 0, freqArray.Length);
            lstFrequencies.Items.Clear();
        }

    }//End Form

}//End Class
