using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnoJey
{
    public partial class FormLedger : Form
    {
        public FormLedger()
        {
            InitializeComponent();
            SetupLedgerGrid();
       }
       private void FormLedger_Load(object sender, EventArgs e)
        {
            LoadLedger();
        }

        private void FormLedger_Activated(object sender, EventArgs e)
        {
            LoadLedger();
        }
        private void SetupLedgerGrid()
        {
            dgvLedger.Columns.Clear();

            dgvLedger.Columns.Add("colDate", "Date");
            dgvLedger.Columns.Add("colDescription", "Description");
            dgvLedger.Columns.Add("colDebit", "Debit");
            dgvLedger.Columns.Add("colCredit", "Credit");
            dgvLedger.Columns.Add("colAmount", "Amount");

            dgvLedger.ReadOnly = true;
            dgvLedger.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLedger.RowHeadersVisible = false;
            dgvLedger.AllowUserToAddRows = false;
            dgvLedger.AllowUserToDeleteRows = false;
            dgvLedger.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLedger.BorderStyle = BorderStyle.Fixed3D;
            dgvLedger.GridColor = Color.Silver;
            dgvLedger.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvLedger.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgvLedger.EnableHeadersVisualStyles = false;
            dgvLedger.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvLedger.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLedger.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 85, 150);
            dgvLedger.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
       public void LoadLedger()
        {
            dgvLedger.Rows.Clear();

            foreach (LedgerRow r in LedgerStorage.Rows)
            {
                dgvLedger.Rows.Add(
                    r.Account,
                    r.Date,
                    r.Debit,
                    r.Credit,
                    r.Balance
                );
            }
        }

        private void dgvLedger_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}