namespace Assignment_1___5__Modify_On_Assigned_Value
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5-	Write C# program that Assigning one value type variable to another and
            // modifying the value of one variable and mention what will happen

            var num1 = 12;
            var num2 = num1;
            num1 = 5;
            Console.WriteLine($"The value of num1 is: {num1}, and num2 is: {num2}");
        }
    }
}
