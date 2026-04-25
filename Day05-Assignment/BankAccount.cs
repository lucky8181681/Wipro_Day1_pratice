using System;

public class BankAccount
{
    public string AccountHolderName { get; set; }
    public double Balance { get; set; }

    public BankAccount(string name, double balance)
    {
        AccountHolderName = name;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            throw new InvalidAmountException("Deposit amount must be greater than 0");
        }

        Balance += amount;
        Console.WriteLine("Deposit successful!");
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            throw new InsufficientBalanceException("Withdrawal amount exceeds balance");
        }

        if (Balance - amount < 1000)
        {
            throw new InsufficientBalanceException("Minimum balance of ₹1000 must be maintained");
        }

        Balance -= amount;
        Console.WriteLine("Withdrawal successful!");
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: ₹{Balance}");
    }
}