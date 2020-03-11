//Reading from Console Writing to Console
using System;

namespace ReadingWritingConsole
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your first name:");
            string FirstName = Console.ReadLine();

            Console.WriteLine("Please enter your last name:");
            string LastName = Console.ReadLine();
            
            //Using placeholder syntax

            Console.WriteLine("Hello !! Welcome to Mastek Training {0}, {1}", FirstName, LastName);

            //Using concatenation 
            //Console.WriteLine("Hello !! Welcome to Mastek Training " + UserName);
        }
    }
}
