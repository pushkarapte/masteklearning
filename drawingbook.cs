using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the pageCount function below.
     */
    static int pageCount(int n, int p) {
        /*
         * Write your code here.
         */
        var minimumPagesToTurn = 0;
        
        if( p == 1 || n == p)
        return minimumPagesToTurn;

        if (n % 2 != 0 && p == n - 1)
        return minimumPagesToTurn;

        if (n % 2 == 0)
        {
        if (p <= n / 2)
        {
        minimumPagesToTurn = p / 2;
        }
        else
        {
        double d = ((double)(n - p)) / 2;
        minimumPagesToTurn = (int)Math.Ceiling(d);
        }
        }
        else
        {
        if (p == (n/2)+1 && n % 4 == 3)
                {
                   
                    minimumPagesToTurn = (n - p) / 2;
                }
                else
                {
                    if (p <= ((n / 2) + 1))
                    {
                        
                        minimumPagesToTurn = p / 2;
                    }
                    else
                    {
                        
                        minimumPagesToTurn = (n - p) / 2;
                    }
                }

            }
            return minimumPagesToTurn;



    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int p = Convert.ToInt32(Console.ReadLine());

        int result = pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
