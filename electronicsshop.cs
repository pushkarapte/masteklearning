using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the getMoneySpent function below.
     */
    static int getMoneySpent(int[] keyboards, int[] drives, int b) {
        /*
         * Write your code here.
         */
          var sortedKeyboardPrices = from keyboard in keyboards
                                 orderby keyboard descending
                                 select keyboard;
            var sortedDrivePrices = from drive in drives
                              orderby drive ascending
                              select drive;
            //default if not able to purchase anything
            var maxMoneySpendable = -1;

              foreach (var keyboard in sortedKeyboardPrices)
            {
                foreach (var drive in sortedDrivePrices)
                {
                    if (keyboard + drive <= b)
                    {
                        if (keyboard + drive > maxMoneySpendable)
                            maxMoneySpendable = keyboard + drive;
                    }
                    else
                        break;
                }
            }
            return maxMoneySpendable;

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] bnm = Console.ReadLine().Split(' ');

        int b = Convert.ToInt32(bnm[0]);

        int n = Convert.ToInt32(bnm[1]);

        int m = Convert.ToInt32(bnm[2]);

        int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
        ;

        int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
        ;
        /*
         * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
         */

        int moneySpent = getMoneySpent(keyboards, drives, b);

        textWriter.WriteLine(moneySpent);

        textWriter.Flush();
        textWriter.Close();
    }
}
