using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AnoJey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private FormLedger ledgerForm; // keep it private

        public FormLedger LedgerForm => ledgerForm;

        public void LoadForm(Form f)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);

            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            LoadForm(new Form3());
            button1.BackColor = Color.FromArgb(0, 70, 160);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            LoadForm(new Form2());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            LoadForm(new AccountData());
        }

        private void btnBalanceSheet_Click(object sender, EventArgs e)
        {
            LoadForm(new FormBalanceSheet());
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            LoadForm(new FormJournal());
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (ledgerForm == null || ledgerForm.IsDisposed)
                ledgerForm = new FormLedger();

            LoadForm(ledgerForm);

  
            ledgerForm.LoadLedger();
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelside_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
