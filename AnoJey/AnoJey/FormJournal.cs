using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AnoJey
{
    public partial class FormJournal : Form
    {
        public FormJournal()
        {
            InitializeComponent();
        }
        private void FormJournal_Load(object sender, EventArgs e)
        {
            DesignDataGrid(dgvJournal);

            LoadJournal();          
        }
        private void LoadJournal()
        {
            dgvJournal.DataSource = null;

            dgvJournal.DataSource = JournalStorage.Transactions.Select(t => new
            {
                Date = t.Date.ToString("yyyy-MM-dd"),
                Description = t.Description,
                Debit = t.DebitAccount,
                Credit = t.CreditAccount,
                Amount = t.Amount.ToString("C2") // formatted currency
            }).ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadJournal();
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
        private void dgvJournal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
