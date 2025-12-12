using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnoJey
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            if (dgvTransactions.Columns.Count == 0)
            {
                dgvTransactions.ColumnCount = 5;
                dgvTransactions.Columns[0].Name = "Date";
                dgvTransactions.Columns[1].Name = "Description";
                dgvTransactions.Columns[2].Name = "Debit Account";
                dgvTransactions.Columns[3].Name = "Credit Account";
                dgvTransactions.Columns[4].Name = "Amount";
            }

            dgvTransactions.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvTransactions.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvTransactions.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgvTransactions.DefaultCellStyle.BackColor = Color.White;
            dgvTransactions.DefaultCellStyle.ForeColor = Color.Black;
            dgvTransactions.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgvTransactions.ReadOnly = true;
            dgvTransactions.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.GridColor = Color.Silver;
            dgvTransactions.BorderStyle = BorderStyle.Fixed3D;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvTransactions.EnableHeadersVisualStyles = false;
            dgvTransactions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 85, 150);
            dgvTransactions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            RefreshTransactions();
        }

        public void RefreshTransactions()
        {
            dgvTransactions.Rows.Clear();

            foreach (var row in TransactionData.Transactions)
            {
                dgvTransactions.Rows.Add(row);
            }
        }
    }
}
