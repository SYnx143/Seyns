using System;
using System.Collections.Generic;

namespace AnoJey
{
    public static class TransactionData
    {
        public static List<string[]> Transactions = new List<string[]>();

        public static event EventHandler TransactionAdded;

        public static void AddTransaction(string[] row)
        {
            Transactions.Add(row);
            OnTransactionAdded();
        }

        private static void OnTransactionAdded()
        {
            TransactionAdded?.Invoke(null, EventArgs.Empty);
        }
    }
}
