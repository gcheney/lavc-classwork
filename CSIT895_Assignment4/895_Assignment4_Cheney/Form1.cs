using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* 
   * Name: Glenodn Cheney
   * CSIT 895 
   * Assignment #4 Parts 1 - 2
*/

namespace _895_Assignment4_Cheney
{
    public partial class Form1 : Form
    {
        private int[] employeeSalaries = new int[10];
        private int salaryIndex = 0;
        private int[] intSalaryFreqs = new int[11];
        const int baseSalary = 200;
        const double commission = .09;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnRestart_Click(sender, e);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int salesAmount, salary;
            const int MAX = 10;
            if (salaryIndex < MAX)
            {
                if (SetAmount(out salesAmount))
                {
                    salary = CalculateAndStoreSalary(salesAmount, salaryIndex);
                    DisplayNewSalary(salary);
                    UpdateAndReplaceFrequency(salary);
                }
                else
                    salaryIndex--;
            }
            else
            {
                MessageBox.Show("Exceeded maximum number of employees\n" 
                    + "which is currently set at " + MAX, "", MessageBoxButtons.OK, MessageBoxIcon.None);
                salaryIndex--;
                txtSales.Clear();
                lblSalary.Text = "";
            }
            salaryIndex++;
        }

        private bool SetAmount(out int sales)
        {
            bool isValid = true;
            string s = txtSales.Text;
            try
            {
                sales = int.Parse(s);
                if (sales < 0)
                    throw new Exception("Sales Amount can NOT be negative!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Sales Amount must be an integer!",
                    "Invalid Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSales.Focus();
                txtSales.SelectAll();
                lblSalary.Text = "";
                sales = 0;
                isValid = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System.Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.None);
                txtSales.Focus();
                txtSales.SelectAll();
                lblSalary.Text = "";
                sales = 0;
                isValid = false;
            }

            return isValid;
        }

        private int CalculateAndStoreSalary(int salesTotal, int index)
        {
            int salesBonus = (int)(salesTotal * commission);
            int salaryTotal = baseSalary + salesBonus;
            employeeSalaries[index] = salaryTotal;
            return salaryTotal;
        }

        private void DisplayNewSalary(int s)
        {
            String salary= s.ToString("c");
            lblSalary.Text = salary;
            lstEmployeeSalaries.Items.Add(salary);
            txtSales.Focus();
            txtSales.SelectAll();
        }

        private void UpdateAndReplaceFrequency(int salary)
        {
            int i = salary / 100;
            if (i >= 10)
            {
                i = 10;
                intSalaryFreqs[i] += 1;
                lstSalaryFreqs.Items[i - 2] = "$1000+" + "\t\t\t" + intSalaryFreqs[i];
            }
            else
            {
                intSalaryFreqs[i] += 1;
                lstSalaryFreqs.Items[i - 2] = "$" + i + "00-" + i + "99" + "\t\t\t" + intSalaryFreqs[i];
            }
        }

        private void txtSales_TextChanged(object sender, EventArgs e)
        {
            lblSalary.Text = "";
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Array.Sort(employeeSalaries, 0, salaryIndex);
            lstEmployeeSalaries.Items.Clear();
            for (int i = 0; i < salaryIndex; i++)
            {
                String s = employeeSalaries[i].ToString("c");
                lstEmployeeSalaries.Items.Add(s);
            }
            txtSales.Focus();
            txtSales.SelectAll();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Array.Clear(employeeSalaries, 0, employeeSalaries.Length);
            salaryIndex = 0;
            Array.Clear(intSalaryFreqs, 0, intSalaryFreqs.Length);
            lstSalaryFreqs.Items.Clear();
            for (int i = 2; i < intSalaryFreqs.Length; i++)
            {
                if (i == 10)
                    lstSalaryFreqs.Items.Add("$1000+" + "\t\t\t" + intSalaryFreqs[i]);
                else
                    lstSalaryFreqs.Items.Add("$" + i + "00-" + i + "99" + "\t\t\t" + intSalaryFreqs[i]);
            }
            lstEmployeeSalaries.Items.Clear();
            txtSales.Clear();
            txtSales.Focus();
            lblSalary.Text = "";
        }
    }
}
