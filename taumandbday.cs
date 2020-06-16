using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'taumBday' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts following parameters:
     *  1. LONG b
     *  2. LONG w
     *  3. LONG bc
     *  4. LONG wc
     *  5. LONG z
     */

    public static long taumBday(long b, long w, long bc, long wc, long z)
    {
        long overallCost =0;

        if (bc + z < wc)
                wc = bc + z;
            else if (wc + z < bc)
                bc = wc + z;
            overallCost = b * bc + w * wc;

            return overallCost;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine().Trim());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            long b = Convert.ToInt64(firstMultipleInput[0]);

            long w = Convert.ToInt64(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            long bc = Convert.ToInt64(secondMultipleInput[0]);

            long wc = Convert.ToInt64(secondMultipleInput[1]);

            long z = Convert.ToInt64(secondMultipleInput[2]);

            long result = Result.taumBday(b, w, bc, wc, z);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
