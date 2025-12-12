namespace AnoJey
{
    partial class FormLedger
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
            this.dgvLedger = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLedger
            // 
            this.dgvLedger.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLedger.Location = new System.Drawing.Point(223, 0);
            this.dgvLedger.Name = "dgvLedger";
            this.dgvLedger.Size = new System.Drawing.Size(1280, 807);
            this.dgvLedger.TabIndex = 0;
            this.dgvLedger.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLedger_CellContentClick);
            // 
            // FormLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 776);
            this.Controls.Add(this.dgvLedger);
            this.Name = "FormLedger";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLedger;
    }
}