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
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        var maxCount = 0;
        var sortedList = a.OrderBy(x => x).ToList();
          for (int i = 0; i < sortedList.Count; i++)
            {
                var currentCount = 1;
                if (i > 0)
                    if (sortedList[i] == sortedList[i-1])
                        continue;

                for (int j = i+1; j < sortedList.Count; j++)
                {
                    if (Math.Abs(sortedList[j]-sortedList[i]) <=1)
                        currentCount++;
                    else
                        break;
                }

                if (currentCount > maxCount)
                    maxCount = currentCount;
            }
            return maxCount;
    }


    

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.pickingNumbers(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
