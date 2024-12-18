using System;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_1___6__Modify_On_Referenced_Variable
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            // 6-	Write C# program that Assigning one reference type variable to another and
            // modifying the object through one variable and mention what will happen

            var p1 = new Person { Name = "Beshoy William" };
            var p2 = p1;

            Console.WriteLine("The result before modification: ");
            Console.WriteLine("Person1.Name: " + p1.Name);
            Console.WriteLine("Person2.Name: " + p2.Name);

            p2.Name = "Beshooo";

            Console.WriteLine("The result after modification: ");
            Console.WriteLine("Person1.Name: " + p1.Name); // p1.Name will reflect the change
            Console.WriteLine("Person2.Name: " + p2.Name);

            // By Modifying on p2 both b1 and b2 changed and b2 affected on b1 because they're saved in the same memory address
        }
    }
}
