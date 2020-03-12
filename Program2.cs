//Use of built in data types 
using System;

namespace BuiltinTypes
{
    class Program
    {
        static void Main()
        {   
            //Boolean
            bool b = true;
            Console.WriteLine(b);

            //Integral
            int i = 0;
            Console.WriteLine("Min = {0}", int.MinValue);
            Console.WriteLine("Max = {0}", int.MaxValue);
            
            //Floating-point
            double d = 598.345923;
            Console.WriteLine(d);

            //String-type and Escape Sequence
           string Name = "\"Pushkar\"";
            Console.WriteLine(Name);
            string Subject = "DSA\nOOP\nPython";
            Console.WriteLine(Subject);
            string Directory = "C:\\Home\\Training\\Csharp";
            Console.WriteLine(Directory);
            //Verbatim Literal 
            string Directory1 = @"C:\\Home\\Training\\Csharp";
            Console.WriteLine(Directory1);
        }

    }
}
