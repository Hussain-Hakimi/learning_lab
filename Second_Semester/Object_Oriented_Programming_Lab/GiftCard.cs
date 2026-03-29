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
// Example usage 
public class proram
{
    public static void Main(string[] args)
    {
        GiftCard myGiftCard = new GiftCard();
        Console.WriteLine(myGiftCard.Recharge(100)); // Recharge the gift card with $100
        Console.WriteLine(myGiftCard.Redeem(30)); // Redeem $30 from the gift card
        Console.WriteLine(myGiftCard.Redeem(80)); // Attempt to redeem $80, which exceeds the current balance
        Console.WriteLine(myGiftCard.Recharge(-20)); // Attempt to recharge with a negative amount
    }

}

