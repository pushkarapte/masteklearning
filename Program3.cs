
//Various operators & Nullable types & Null coalescing
using System;

namespace Operatorsincsharp
{
    class Program
    {
        static void Main()
        {


            float num = 20;
            float denom = 40;
            float result = num / denom;
            Console.WriteLine("Result = {0}", result);

            int num1 = 100;
            int denom1 = 80;
            int R = num1 % denom1;
            Console.WriteLine("Result = {0}", R);

            int number = 50;
            if (number == 50)
            {
                Console.WriteLine("number is {0}", number);
            }
            else
            {
                Console.WriteLine("number is not {0}", number);
            }

            int num2 = 40; int num3 = 60;
            if (num2 == 40 || num == 60)
            {
                Console.WriteLine("Match");
            }

            int Num = 4;
            bool IsNum44 = Num == 54 ? true : false;

            /* if (Num == 44)
             {
                 IsNum44 = true;
             }
             else
             {
                 IsNum44 = false;
             }
             */
            Console.WriteLine("number == 44 is {0}", IsNum44);
           

            // Nullable types example
            
            bool? AreYouMajor = null;

            if (AreYouMajor == true)
            {
                Console.WriteLine("He is a major");
            }
            else if (AreYouMajor == false)
            {
                Console.WriteLine("He is not a major");
            }
            else
            {
                Console.WriteLine("Did not answer the question");
            }

            int? TOS = null;
            int AT = TOS ?? 0;

           /* if (TOS == null)
            {
                AT = 0;
            }
            else
            {
                AT = (int)TOS;

            }
             */
            Console.WriteLine("AT are {0}", AT);
        }

    }
}