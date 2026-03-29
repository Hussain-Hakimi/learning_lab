using System;
using System.Security.Cryptography.X509Certificates;

public class GiftCard
{
    private int _id;
    private decimal _amount;

    public string Redeem(decimal amount)
    {
        if (amount > _amount)
        {
            return "Field amount must be less than or equal to the current balance.";

        }
        _amount -= amount;
        return $"Redeemed {amount:C}. Remaining balance: {_amount:C}.";
    }

    public string Recharge(decimal amount)
    {
        if (amount <= 0)
        {
            return "Recharge amount must be greater than zero.";
        }
        _amount += amount;
        return $"Recharged {amount:C}. Current balance: {_amount:C}.";
    }

}

