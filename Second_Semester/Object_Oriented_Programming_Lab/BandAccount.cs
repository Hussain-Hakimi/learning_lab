internal class BankAccount
{
    public int AccountNumber { get; }           // Read‑only after construction
    public decimal Balance { get; private set; } // Can be changed only within the class

    // Constructor that sets account number and initial balance
    public BankAccount(int accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Constructor that sets account number and defaults balance to 0
    public BankAccount(int accountNumber) : this(accountNumber, 0)
    {
    }

    // Optional: methods to modify balance
    public void Deposit(decimal amount)
    {
        if (amount > 0)
            Balance += amount;
    }

    public bool Withdraw(decimal amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
}

