using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("Sneha", 5000);

        try
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");

            Console.Write("Choose option: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter deposit amount: ");
                    double deposit = double.Parse(Console.ReadLine());
                    account.Deposit(deposit);
                    break;

                case 2:
                    Console.Write("Enter withdrawal amount: ");
                    double withdraw = double.Parse(Console.ReadLine());
                    account.Withdraw(withdraw);
                    break;

                case 3:
                    account.CheckBalance();
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
        catch (InvalidAmountException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Invalid input: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Transaction completed.");
        }
    }
}