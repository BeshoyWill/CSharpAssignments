namespace Assignment_1___11__Change_Date_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11-	Write a program that takes the date from the user and displays it in various formats using string interpolation.
            // Ex :
            // Today’s date : 20 , 11 , 2001
            // Today's date : 20 / 11 / 2001
            // Today's date : 20 – 11 – 2001

            Console.WriteLine("Enter a date in the format yyyy-mm-dd: ");
            string date_input = Console.ReadLine();

            if (DateTime.TryParse(date_input, out DateTime date))
            {
                Console.WriteLine($"Today's date: {date:dd}, {date:MM}, {date:yyyy}");
                Console.WriteLine($"Today's date: {date:dd} / {date:MM} / {date:yyyy}");
                Console.WriteLine($"Today's date: {date:dd} - {date:MM} - {date:yyyy}");
            }
            else
            {
                Console.WriteLine("Invalid date format. Enter right one next time");
            }
        }
    }
}
