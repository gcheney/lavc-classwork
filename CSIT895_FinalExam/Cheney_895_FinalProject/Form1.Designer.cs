namespace Cheney_895_FinalProject
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
            this.btnSetBase = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOutDigits = new System.Windows.Forms.Label();
            this.btnShowFreq = new System.Windows.Forms.Button();
            this.lstFrequencies = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSetBase
            // 
            this.btnSetBase.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetBase.Location = new System.Drawing.Point(23, 201);
            this.btnSetBase.Name = "btnSetBase";
            this.btnSetBase.Size = new System.Drawing.Size(133, 23);
            this.btnSetBase.TabIndex = 0;
            this.btnSetBase.Text = "Select Numeric Base";
            this.btnSetBase.UseVisualStyleBackColor = true;
            this.btnSetBase.Click += new System.EventHandler(this.btnSetBase_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(184, 201);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblOutDigits
            // 
            this.lblOutDigits.AutoSize = true;
            this.lblOutDigits.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOutDigits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutDigits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOutDigits.Location = new System.Drawing.Point(23, 167);
            this.lblOutDigits.Name = "lblOutDigits";
            this.lblOutDigits.Size = new System.Drawing.Size(18, 15);
            this.lblOutDigits.TabIndex = 2;
            this.lblOutDigits.Text = "   ";
            // 
            // btnShowFreq
            // 
            this.btnShowFreq.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFreq.Location = new System.Drawing.Point(23, 53);
            this.btnShowFreq.Name = "btnShowFreq";
            this.btnShowFreq.Size = new System.Drawing.Size(88, 38);
            this.btnShowFreq.TabIndex = 3;
            this.btnShowFreq.Text = "Show Digit Frequencies";
            this.btnShowFreq.UseVisualStyleBackColor = true;
            this.btnShowFreq.Click += new System.EventHandler(this.btnShowFreq_Click);
            // 
            // lstFrequencies
            // 
            this.lstFrequencies.FormattingEnabled = true;
            this.lstFrequencies.Location = new System.Drawing.Point(181, 53);
            this.lstFrequencies.Name = "lstFrequencies";
            this.lstFrequencies.Size = new System.Drawing.Size(149, 108);
            this.lstFrequencies.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digit                       Frequency";
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(23, 114);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(88, 34);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order Digits";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(470, 287);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstFrequencies);
            this.Controls.Add(this.btnShowFreq);
            this.Controls.Add(this.lblOutDigits);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSetBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSetBase;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOutDigits;
        private System.Windows.Forms.Button btnShowFreq;
        private System.Windows.Forms.ListBox lstFrequencies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrder;
    }
}

