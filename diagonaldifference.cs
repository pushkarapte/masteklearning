using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
               int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[n, n];
        for (int i = 0; i < n; i++)
        {            
            string input = Console.ReadLine();
            string[] input_1 = input.Split();
            for (int j = 0; j < n; j++)
            {
                array[i,j] = Convert.ToInt32(input_1[j]);
            }
            
        }
        long sumDiag1=0;
        long sumDiag2=0;
        for (int i = 0; i < n; i++)
        {
            sumDiag1 += Convert.ToInt64(array[i, i]);
        }
        for (int i = 0; i < n; i++)
        {
            sumDiag2 += Convert.ToInt64(array[((n-1) - i), i]);
        }
        Console.WriteLine(Math.Abs(sumDiag1-sumDiag2));
    }
}
