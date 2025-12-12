using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AnoJey
{
    public partial class FormBalanceSheet : Form
    {
        public FormBalanceSheet()
        {
            InitializeComponent();
        }

        private void FormBalanceSheet_Load(object sender, EventArgs e)
        {
            DesignDataGrid(dgvAssets);
            DesignDataGrid(dgvLiabilitiesEquity);

            LoadBalanceSheet();

            TransactionData.TransactionAdded += TransactionData_TransactionAdded;
        }

        private void TransactionData_TransactionAdded(object sender, EventArgs e)
        {
            LoadBalanceSheet();
        }

        private void DesignDataGrid(DataGridView dgv)
        {
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.GridColor = Color.Silver;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 85, 150);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private string FormatAmount(decimal value, int rowIndex)
        {
            string formatted = value < 0
                ? $"({Math.Abs(value):N2})"
                : $"{value:N2}";

     
            if (rowIndex == 0)
                return "₱ " + formatted;

            return formatted;
        }

        private void LoadBalanceSheet()
        {
            var allAccounts = AccountStorage.Accounts;

            var assetAccounts = allAccounts
                .Where(a => a.Type == "ASSET" && a.Balance != 0)
                .ToList();

            var liabilityAccounts = allAccounts
                .Where(a => a.Type == "LIABILITY" && a.Balance != 0)
                .ToList();

            var equityAccounts = allAccounts
                .Where(a => a.Type == "EQUITY" && a.Balance != 0)
                .ToList();

      
            dgvAssets.DataSource = assetAccounts
                .Select((a, index) => new
                {
                    Account = a.AccountName,
                    Amount = FormatAmount(a.Balance, index)
                })
                .ToList();

           
            var rightSide = liabilityAccounts.Concat(equityAccounts).ToList();

            dgvLiabilitiesEquity.DataSource = rightSide
                .Select((a, index) => new
                {
                    Account = a.AccountName,
                    Amount = FormatAmount(a.Balance, index)
                })
                .ToList();

         
            decimal totalAssets = assetAccounts.Sum(a => a.Balance);
            decimal totalLiabilitiesEquity = rightSide.Sum(a => a.Balance);

            lblTotalAssets.Text = $"Total Assets: ₱ {totalAssets:N2}";
            lblTotalAssets.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            lblTotalLiabilitiesEquity.Text = $"Total Liabilities & Equity: ₱ {totalLiabilitiesEquity:N2}";
            lblTotalLiabilitiesEquity.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
