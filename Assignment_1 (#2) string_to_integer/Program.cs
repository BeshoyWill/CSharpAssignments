namespace Assignment_1__string_to_integer_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2-	Write C# program that converts a string to an integer, but the string
            // contains non-numeric characters. And mention what will happen 
            Console.WriteLine("Enter the string that will be converted into a number: ");
            string input = Console.ReadLine();
            int convertedNumber = Convert.ToInt32(input);
            Console.WriteLine("The number is: " + convertedNumber);
        }
    }
}
