using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DatabaseConnection objConnect;
        string conString;

        DataSet data_set;
        DataRow data_row;

        int numRows;
        int currentRow = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            initForm();

            try
            {
                objConnect = new DatabaseConnection();
                conString = Properties.Settings.Default.EmployeesConnectionString;
                
                objConnect.ConnectionString = conString;
                objConnect.SQL = Properties.Settings.Default.SQL;

                data_set = objConnect.GetConnection;
                numRows = data_set.Tables[0].Rows.Count;

                NavigateRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NavigateRecords()
        {
            data_row = data_set.Tables[0].Rows[currentRow];
            txtFirstName.Text = data_row.ItemArray.GetValue(1).ToString();
            txtLastName.Text = data_row.ItemArray.GetValue(2).ToString();
            txtJobTitle.Text = data_row.ItemArray.GetValue(3).ToString();
            txtDepartment.Text = data_row.ItemArray.GetValue(4).ToString();
            updateLabel();
        }

        private void initForm()
        {
            btnNew.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtRecord.Enabled = false;

            foreach (Button btn in navPanel.Controls)
            {
                btn.Enabled = true;
            }

            foreach (Control control in txtPanel.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                    control.Enabled = false;
                }
            }

            foreach (Button btn in grpBoxEditRecord.Controls)
            {
                btn.Enabled = true;
            }
        }

        private void updateLabel()
        {
            txtRecord.Text = "Record " + (currentRow + 1) + " of " + numRows;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentRow != numRows - 1)
            {
                currentRow++;
                NavigateRecords();
            }
            else
            {
                currentRow = 0;
                NavigateRecords();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentRow > 0)
            {
                currentRow--;
                NavigateRecords();
            }
            else
            {
                currentRow = numRows - 1;
                NavigateRecords();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (currentRow != 0)
            {
                currentRow = 0;
                NavigateRecords();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (currentRow != numRows - 1)
            {
                currentRow = numRows - 1;
                NavigateRecords();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach (Control control in txtPanel.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = "";
                    control.Enabled = true;
                }
            }

            foreach (Button btn in navPanel.Controls)
            {
                btn.Enabled = false;
            }

            foreach (Button btn in grpBoxEditRecord.Controls)
            {
                btn.Enabled = false;
            }

            btnNew.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtFirstName.Focus();
            txtFirstName.SelectAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            initForm();
            NavigateRecords();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool validRecord = true;

            foreach (Control control in txtPanel.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text.Equals(""))
                    {
                        MessageBox.Show(this, "Please fill in the " + control.Name.Substring(3) + " section of the form.", 
                            "Incomplete Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        control.Focus();
                        validRecord = false;
                    }
                }
            }

            if (validRecord)
            {
                try
                {
                    DataRow row = data_set.Tables[0].NewRow();

                    row[1] = txtFirstName.Text;
                    row[2] = txtLastName.Text;
                    row[3] = txtJobTitle.Text;
                    row[4] = txtDepartment.Text;

                    data_set.Tables[0].Rows.Add(row);

                    objConnect.UpdateDatabase(data_set);
                    numRows += 1;
                    currentRow = numRows - 1;
                    MessageBox.Show(this, "Database updated - New Record Added", "Update Succesful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "System Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                initForm();
                NavigateRecords();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Enabled)//Update already clicked once
            {
                bool validRecord = true;

                foreach (Control control in txtPanel.Controls)
                {
                    if (control is TextBox)
                    {
                        if (control.Text.Equals(""))
                        {
                            MessageBox.Show(this, "Please fill in the " + control.Name.Substring(3) + " section of the form.", 
                                "Incomplete Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            control.Focus();
                            validRecord = false;
                        }
                    }
                }

                if (validRecord)
                {
                    try
                    {
                        DataRow row = data_set.Tables[0].Rows[currentRow];

                        row[1] = txtFirstName.Text;
                        row[2] = txtLastName.Text;
                        row[3] = txtJobTitle.Text;
                        row[4] = txtDepartment.Text;

                        objConnect.UpdateDatabase(data_set);
                        MessageBox.Show(this, "Record has been succesfully updated", "Update Succesful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        initForm();
                        NavigateRecords();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, ex.Message, "System Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else//Update clicked for first time
            {
                foreach (Control control in txtPanel.Controls)
                {
                    if (control is TextBox)
                    {
                        control.Enabled = true;
                    }
                }

                txtFirstName.Focus();
                txtFirstName.SelectAll();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Are you sure you want to delete this record?", 
                                    "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                try
                {
                    data_set.Tables[0].Rows[currentRow].Delete();
                    objConnect.UpdateDatabase(data_set);

                    numRows = data_set.Tables[0].Rows.Count;
                    currentRow--;
                    NavigateRecords();
                    MessageBox.Show(this, "Record has been succesfully deleted", "Delete Succesful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "System Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
