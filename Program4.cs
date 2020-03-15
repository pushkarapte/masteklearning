//Use of various statements like if,else,switch etc
using System;


namespace Statementsincsharp
{
    class Program
    {
        static void Main()
        {
            int TotalCoffeeCost = 0;
            Start:
            Console.WriteLine("Please select your coffee size ----> 1 - Small , 2 - Medium , 3 - Large");
            int UserChoice = int.Parse(Console.ReadLine());

            switch(UserChoice)
            {
                case 1:
                    TotalCoffeeCost += 1;
                    break;
             case 2:
                    TotalCoffeeCost += 2;
                    break;
                     case 3:
                    TotalCoffeeCost += 3;
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid",UserChoice);
            goto Start;
            }
            
            Decision:
            Console.WriteLine("Do you want to buy another coffee - YES or NO ?");
            string UserDecision = Console.ReadLine();

            switch (UserDecision.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Your choice {0} is invalid, Please try again...... ",UserDecision);
                    goto Decision;
            }

            Console.WriteLine("Thankyou for shopping with us");
            Console.WriteLine("Bill Amount is {0}", TotalCoffeeCost);
            
            /* Console.WriteLine("Please enter the number:");

            int UserNumber = int.Parse(Console.ReadLine());
            // if else example
             if (UserNumber == 10)
             {
                 Console.WriteLine("Your number is ten");
             }
             else if (UserNumber == 12)
             {
                 Console.WriteLine("Your number is twelve");
             }
             else if (UserNumber != 10 && UserNumber != 12)
             {
                 Console.WriteLine("Your number is different");
             }
           
             if (UserNumber == 11 || UserNumber == 13)
             {
                 Console.WriteLine("Number is 11 or 13");
             }
             else
             {
                 Console.WriteLine("Number is not between 10 to 13");

             }
            // switch  and break 
            switch (UserNumber)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Your number is {0}", UserNumber);
                    break;
                default:
                    Console.WriteLine("Your number is not 10,20 or 30");
                    break;


            } */

        }
    }
}