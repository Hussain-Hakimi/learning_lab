using System;

public class AccountBank
{
    private static string Bankname = "Central Bank";  // Static ✓
    private static int TotalAccount = 0;              // Static ✓
    private decimal _balance;

    public int AccountNumber { get; set; }            // Instance ✓

    public decimal Balance                            // Instance ✓
    {
        get { return _balance; }
        set
        {
            if (value > 0)
                _balance = value;
            else
                Console.WriteLine("Balance cannot be negative.");
        }
    }

    // Static method to change bank name for ALL accounts
    public static void ChangeBankName(string newName)
    {
        Bankname = newName;
        Console.WriteLine($"Bank name changed to: {Bankname} (affects all accounts)");
    }

    public static void ShowBankName()  // Show current bank name
    {
        Console.WriteLine($"Bank Name: {Bankname}");
    }

    public AccountBank(decimal initialBalance)
    {
        TotalAccount++;
        AccountNumber = TotalAccount;
        Balance = initialBalance;
    }

    public void DisplayAccountInfo()  // Instance method
    {
        Console.WriteLine($"Bank: {Bankname}, Account: {AccountNumber}, Balance: {Balance:C}");
    }
}

