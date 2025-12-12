using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnoJey
{
    public partial class AccountData : Form
    {
        public AccountData()
        {
            InitializeComponent();
        }

        public void RefreshAccounts()
        {
            dataGridView1.Rows.Clear();

            foreach (var a in AccountStorage.Accounts)
            {
                dataGridView1.Rows.Add(
                    a.AccountName,
                    a.Type,
                    Math.Abs(a.Balance).ToString("N2")
                );
            }
        }

        private void AccountData_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.ColumnCount = 3;
                dataGridView1.Columns[0].Name = "Account";
                dataGridView1.Columns[1].Name = "Type";
                dataGridView1.Columns[2].Name = "Balance";
            }

            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.GridColor = Color.Silver;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(45, 85, 150);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            RefreshAccounts();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
        }
    }
}
