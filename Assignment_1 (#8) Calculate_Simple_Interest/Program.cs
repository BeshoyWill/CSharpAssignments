using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_1___8__Calculate_Simple_Interest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8-	Write a program that calculates the simple interest given the principal
            // amount, rate of interest, and time. The formula for simple interest is 
            // Interest = (principal * rate * time) / 100.

            decimal principal_amount, rate, time, interest;

            Console.WriteLine("Enter The amount of principal: ");
            principal_amount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate value: ");
            rate = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ente the time taken: ");
            time = decimal.Parse(Console.ReadLine());

            interest = (principal_amount * rate * time) / 100;

            Console.WriteLine("The Interest value is: " + interest);
        }
    }
}
