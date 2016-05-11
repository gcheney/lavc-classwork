namespace _895_Assignment4_Cheney
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSales = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.TextBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstEmployeeSalaries = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.lstSalaryFreqs = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Employee\'s Sales:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(50, 67);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(156, 28);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate Salary";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salary for this Employee: ";
            // 
            // txtSales
            // 
            this.txtSales.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSales.Location = new System.Drawing.Point(268, 34);
            this.txtSales.Name = "txtSales";
            this.txtSales.Size = new System.Drawing.Size(163, 22);
            this.txtSales.TabIndex = 3;
            this.txtSales.TextChanged += new System.EventHandler(this.txtSales_TextChanged);
            // 
            // lblSalary
            // 
            this.lblSalary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(268, 115);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.ReadOnly = true;
            this.lblSalary.Size = new System.Drawing.Size(163, 26);
            this.lblSalary.TabIndex = 4;
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(472, 27);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(92, 34);
            this.btnRestart.TabIndex = 5;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Employee Salaries:";
            // 
            // lstEmployeeSalaries
            // 
            this.lstEmployeeSalaries.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstEmployeeSalaries.FormattingEnabled = true;
            this.lstEmployeeSalaries.ItemHeight = 18;
            this.lstEmployeeSalaries.Location = new System.Drawing.Point(382, 243);
            this.lstEmployeeSalaries.Name = "lstEmployeeSalaries";
            this.lstEmployeeSalaries.Size = new System.Drawing.Size(182, 238);
            this.lstEmployeeSalaries.TabIndex = 7;
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(392, 173);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(109, 31);
            this.btnSort.TabIndex = 8;
            this.btnSort.Text = "Sort Salaries";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // lstSalaryFreqs
            // 
            this.lstSalaryFreqs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSalaryFreqs.FormattingEnabled = true;
            this.lstSalaryFreqs.ItemHeight = 18;
            this.lstSalaryFreqs.Location = new System.Drawing.Point(52, 243);
            this.lstSalaryFreqs.Name = "lstSalaryFreqs";
            this.lstSalaryFreqs.Size = new System.Drawing.Size(237, 238);
            this.lstSalaryFreqs.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Salary Range";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Frequency";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 501);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstSalaryFreqs);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lstEmployeeSalaries);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.txtSales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSales;
        private System.Windows.Forms.TextBox lblSalary;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstEmployeeSalaries;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox lstSalaryFreqs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

