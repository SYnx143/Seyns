namespace AnoJey
{
    partial class FormJournal
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvJournal = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(158)))));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRefresh.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefresh.Location = new System.Drawing.Point(753, 775);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(213, 37);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseMnemonic = false;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // dgvJournal
            // 
            this.dgvJournal.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJournal.Location = new System.Drawing.Point(223, 0);
            this.dgvJournal.Name = "dgvJournal";
            this.dgvJournal.Size = new System.Drawing.Size(1290, 807);
            this.dgvJournal.TabIndex = 3;
            this.dgvJournal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJournal_CellContentClick);
            // 
            // FormJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 824);
            this.Controls.Add(this.dgvJournal);
            this.Controls.Add(this.btnRefresh);
            this.Name = "FormJournal";
            this.Text = "FormJournal";
            this.Load += new System.EventHandler(this.FormJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJournal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvJournal;
    }
}