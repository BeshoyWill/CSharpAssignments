namespace Assignment_1_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1-	Write a program that allows the user to enter a number then print it.
            Console.WriteLine("Enter Your Number here:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Number You've Entered is: " + x);
        }
    }
}
