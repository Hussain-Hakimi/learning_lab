using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BankAcount
{
    public int AccountNumber { get; private set;  }
    private decimal _balance;
    public decimal Balance
    {
        get { return _balance; }
        set
        {
            if (value >= 0)
            {   _balance = value; 
            }
            else
            {
                Console.WriteLine("Balance cannot be negative.");
            }
        } 

    }

    public BankAcount(int accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }
        else
        {
            Console.WriteLine("Withdrawal amount must be positive.");
        }
    }

}
public class program
{
    public static void Main()
    {
        BankAcount account1 = new BankAcount(12345, 1000m);
        account1.Deposit(500m);
        account1.Withdraw(200m);
        account1.Withdraw(1500m); // Should show insufficient funds
        account1.Deposit(-50m);   // Should show invalid deposit
        account1.Withdraw(-30m);  // Should show invalid withdrawal
    }
}