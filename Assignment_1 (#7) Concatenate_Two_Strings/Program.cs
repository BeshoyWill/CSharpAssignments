using System.ComponentModel;

namespace Assignment_1___7__Concatenate_Two_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7 - Write C# program that take two string variables and print them as one variable.
            Console.WriteLine("Enter The First String: ");
            string x = Console.ReadLine();

            Console.WriteLine("Enter The Second String: ");
            string y = Console.ReadLine();

            Console.WriteLine("The result of Concatenated Two Strings:");
            Console.WriteLine(x + y);

        }
    }
}
