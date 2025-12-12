using System.Collections.Generic;

public static class LedgerStorage
{
    public static List<LedgerRow> Rows = new List<LedgerRow>();
}

public class LedgerRow
{
    public string Account { get; set; }
    public string Date { get; set; }
    public string Debit { get; set; }
    public string Credit { get; set; }
    public string Balance { get; set; }
}
