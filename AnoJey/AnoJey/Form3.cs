using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnoJey
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
                    }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (!decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                MessageBox.Show("Enter a valid amount.");
                return;
            }


            string[] row = new string[]
            {
        dtpDate.Value.ToShortDateString(),
        txtDescription.Text,               
        cmbDebit.Text,                    
        cmbCredit.Text,                   
        amount.ToString("F2")              
            };

        
            TransactionData.Transactions.Add(row);

            JournalStorage.Transactions.Add(new JournalEntry
            {
                Date = dtpDate.Value,
                Description = txtDescription.Text,
                DebitAccount = cmbDebit.Text,
                CreditAccount = cmbCredit.Text,
                Amount = amount
            });

          
            AccountStorage.EnsureAccountExists(cmbDebit.Text, AccountStorage.GuessType(cmbDebit.Text));
            AccountStorage.EnsureAccountExists(cmbCredit.Text, AccountStorage.GuessType(cmbCredit.Text));
            AccountStorage.UpdateBalance(cmbDebit.Text, amount, true);
            AccountStorage.UpdateBalance(cmbCredit.Text, amount, false); 


       


                    LedgerStorage.Rows.Add(new LedgerRow
                    {
                        Account = cmbDebit.Text,
                        Date = dtpDate.Value.ToShortDateString(),
                        Debit = amount.ToString("N2"),
                        Credit = "",
                        Balance = amount.ToString("N2")
                    });

                          
                            LedgerStorage.Rows.Add(new LedgerRow
                            {
                                Account = cmbCredit.Text,
                                Date = dtpDate.Value.ToShortDateString(),
                                Debit = "",
                                Credit = amount.ToString("N2"),
                                Balance = amount.ToString("N2")
                            });


      
            foreach (Form f in Application.OpenForms)
            {
                if (f is Form2 transactionsForm)
                    transactionsForm.RefreshTransactions();

                if (f is FormLedger ledgerForm)
                    ledgerForm.LoadLedger();
            }

        
            MessageBox.Show("Transaction added successfully!");

            txtDescription.Clear();
            txtAmount.Clear();
            cmbDebit.SelectedIndex = -1;
            cmbCredit.SelectedIndex = -1;
        }




        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
