using System;
using System.Collections.Generic;

namespace AnoJey
{
    public class JournalEntry
    {
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string DebitAccount { get; set; }
        public string CreditAccount { get; set; }
        public decimal Amount { get; set; }
    }

    public static class JournalStorage
    {
        public static List<JournalEntry> Transactions = new List<JournalEntry>();
    }
}