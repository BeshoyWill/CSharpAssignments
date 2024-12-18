namespace Assignment_1___4__Extract_Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4-	Write C# program that Extract a substring from a given string.

            Console.WriteLine("Enter Your String you want to extract the last two characters of it: ");
            string our_string = Console.ReadLine();
            if (our_string.Length >= 2)
            {
                string sub_string = our_string.Substring(our_string.Length - 2);
                Console.WriteLine("We will print the last two characters of our string: " + sub_string);
            }
            else
            {
                Console.WriteLine("The string is too short to extract the last two characters.");
            }
        }
    }
}
