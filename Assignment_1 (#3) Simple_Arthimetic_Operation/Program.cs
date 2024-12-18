namespace Assignment_1___3__Simple_Arthimetic_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3-	Write C# program that Perform a simple arithmetic operation with
            //floating-point numbers And mention what will happen

            Console.WriteLine("Enter Your First Number : ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Second Number : ");
            float b = float.Parse(Console.ReadLine());

            float add = a + b;
            float sub = a - b;
            float mul = a * b;
            float div = b != 0 ? a / b : float.PositiveInfinity;

            Console.WriteLine("Addition: " + add);
            Console.WriteLine("Subtraction: " + sub);
            Console.WriteLine("Multiplication: " + mul);
            Console.WriteLine("Division: " + div);
        }
    }
}
