namespace Assignment_1___10__Check_Temperate_Using_Ternary_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 10-	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good.
            // Assign the result in a variable then display the result.Assume that below 10 degrees is "Just Cold",
            // above 30 degrees is "Just Hot", and anything else is "Just Good".

            Console.WriteLine("Enter The temperature value: ");
            decimal Temp = decimal.Parse(Console.ReadLine());

            string result = Temp < 10 ? "Just Cold" : (Temp > 30 ? "Just Hot" : "Just Good");

            Console.WriteLine("The temperature is: " + result);
        }
    }
}
