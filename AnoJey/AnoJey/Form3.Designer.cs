namespace AnoJey
{
    partial class Form3
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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbCredit = new System.Windows.Forms.ComboBox();
            this.cmbDebit = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(813, 495);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(331, 38);
            this.txtAmount.TabIndex = 9;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbCredit
            // 
            this.cmbCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCredit.FormattingEnabled = true;
            this.cmbCredit.Items.AddRange(new object[] {
            "Cash",
            "Accounts Receivable",
            "Inventory",
            "Prepaid Expense",
            "Equipment",
            "Accounts Payable",
            "Notes Payable",
            "Owner\'s Capital",
            "Sales Revenue",
            "Service Revenue",
            "Cost of Goods Sold",
            "Rent Expense",
            "Salaries Expense",
            "Utilities Expense"});
            this.cmbCredit.Location = new System.Drawing.Point(813, 426);
            this.cmbCredit.Name = "cmbCredit";
            this.cmbCredit.Size = new System.Drawing.Size(331, 33);
            this.cmbCredit.TabIndex = 8;
            this.cmbCredit.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cmbDebit
            // 
            this.cmbDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDebit.FormattingEnabled = true;
            this.cmbDebit.Items.AddRange(new object[] {
            "Cash",
            "Accounts Receivable",
            "Inventory",
            "Prepaid Expense",
            "Equipment",
            "Accounts Payable",
            "Notes Payable",
            "Owner\'s Capital",
            "Sales Revenue",
            "Service Revenue",
            "Cost of Goods Sold",
            "Rent Expense",
            "Salaries Expense",
            "Utilities Expense"});
            this.cmbDebit.Location = new System.Drawing.Point(813, 360);
            this.cmbDebit.Name = "cmbDebit";
            this.cmbDebit.Size = new System.Drawing.Size(331, 33);
            this.cmbDebit.TabIndex = 7;
            this.cmbDebit.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(813, 227);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(331, 29);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(813, 301);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(331, 31);
            this.txtDescription.TabIndex = 6;
            this.txtDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(647, 596);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(260, 50);
            this.button1.TabIndex = 18;
            this.button1.Text = "ADD TRANSACTION";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(426, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(337, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "DATE (DD-MM-YYYY):";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(426, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DESCRIPTION";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(426, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(257, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "DEBIT ACCOUNT";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(426, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(278, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "CREDIT ACCOUNT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(426, 495);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "AMOUNT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.dtpDate);
            this.panel2.Controls.Add(this.cmbDebit);
            this.panel2.Controls.Add(this.cmbCredit);
            this.panel2.Controls.Add(this.txtAmount);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(-2, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1595, 713);
            this.panel2.TabIndex = 19;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1591, 709);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbDebit;
        private System.Windows.Forms.ComboBox cmbCredit;
        private System.Windows.Forms.TextBox txtAmount;
    }
}