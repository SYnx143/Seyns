using System.Collections.Generic;
using System.Linq;

namespace AnoJey
{
    public class AccountInfo
    {
        public string AccountName { get; set; }
        public string Type { get; set; } 
        public decimal Balance { get; set; }
    }

    public static class AccountStorage
    {
        public static List<AccountInfo> Accounts = new List<AccountInfo>()
        {
            new AccountInfo { AccountName = "Cash", Type = "ASSET", Balance = 0m },
            new AccountInfo { AccountName = "Accounts Receivable", Type = "ASSET", Balance = 0m },
            new AccountInfo { AccountName = "Inventory", Type = "ASSET", Balance = 0m },
            new AccountInfo { AccountName = "Prepaid Expense", Type = "ASSET", Balance = 0m },
            new AccountInfo { AccountName = "Equipment", Type = "ASSET", Balance = 0m },
            new AccountInfo { AccountName = "Accounts Payable", Type = "LIABILITY", Balance = 0m },
            new AccountInfo { AccountName = "Notes Payable", Type = "LIABILITY", Balance = 0m },
            new AccountInfo { AccountName = "Owner's Capital", Type = "EQUITY", Balance = 0m },
            new AccountInfo { AccountName = "Sales Revenue", Type = "INCOME", Balance = 0m },
            new AccountInfo { AccountName = "Service Revenue", Type = "INCOME", Balance = 0m },
            new AccountInfo { AccountName = "Cost of Goods Sold", Type = "EXPENSE", Balance = 0m },
            new AccountInfo { AccountName = "Rent Expense", Type = "EXPENSE", Balance = 0m },
            new AccountInfo { AccountName = "Salaries Expense", Type = "EXPENSE", Balance = 0m },
            new AccountInfo { AccountName = "Utilities Expense", Type = "EXPENSE", Balance = 0m }
        };

        public static void EnsureAccountExists(string accountName, string type)
        {
            if (!Accounts.Any(a => a.AccountName == accountName))
            {
                Accounts.Add(new AccountInfo { AccountName = accountName, Type = type ?? "Unknown", Balance = 0m });
            }
        }

        public static void UpdateBalance(string accountName, decimal amount, bool isDebit)
        {
            var acc = Accounts.FirstOrDefault(a => a.AccountName == accountName);
            if (acc == null) return;

         
            if (acc.Type == "ASSET" || acc.Type == "EXPENSE")
            {
                acc.Balance += isDebit ? amount : -amount;
            }
            else if (acc.Type == "LIABILITY" || acc.Type == "EQUITY" || acc.Type == "INCOME")
            {
                acc.Balance += isDebit ? -amount : amount;
            }
        }




        public static string GuessType(string accountName)
        {
            var name = accountName.ToLower();

            if (name.Contains("cash") ||
        name.Contains("receivable") ||
        name.Contains("inventory") ||
        name.Contains("prepaid") ||
        name.Contains("equipment"))
                return "ASSET";

            if (name.Contains("payable") ||
                name.Contains("notes payable"))
                return "LIABILITY";

            if (name.Contains("capital") ||
                name.Contains("owner"))
                return "EQUITY";

            if (name.Contains("revenue") ||
                name.Contains("sales") ||
                name.Contains("service"))
                return "INCOME";

            if (name.Contains("expense") ||
                name.Contains("rent") ||
                name.Contains("utilities") ||
                name.Contains("salary") ||
                name.Contains("salaries") ||
                name.Contains("cost of goods"))
                return "EXPENSE";

            return "ASSET"; // default
        }


    }
}
