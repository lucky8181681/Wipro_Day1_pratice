using System;
class LateNightException : Exception
{
    public LateNightException(string message) : base(message)
    {
    }
}

class SleepChecker
{
    public void CheckSleepTime()
    {
        try
        {
            Console.WriteLine("Enter your sleeping time (hour 1–12 format):");
            int hour = Convert.ToInt32(Console.ReadLine());

            if (hour == 12 || hour == 1)
            {
                throw new LateNightException("Sleeping at midnight or after is not healthy!");
            }
            else
            {
                Console.WriteLine("Good sleep schedule 👍");
            }
        }
        catch (LateNightException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Enter a valid number.");
        }
        finally
        {
            Console.WriteLine("Sleep check completed.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        SleepChecker obj = new SleepChecker();
        obj.CheckSleepTime();
    }
}