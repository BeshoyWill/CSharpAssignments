namespace Assignment_1___9__Calculate_Body_Mass_Index
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9-	Write a program that calculates the Body Mass Index (BMI) given a person's weight
            // in kilograms and height in meters. The formula for BMI is
            // BMI = (Weight) / (Height * Height)

            decimal Weight, Height, BMI;

            Console.WriteLine("Enter the weight of the body in Kilogram: ");
            Weight = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the height of the body in Meter: ");
            Height = decimal.Parse(Console.ReadLine());

            BMI = Weight / (Height * Height);

            Console.WriteLine("The Body Mass Index value is: " + BMI);
        }
    }
}
