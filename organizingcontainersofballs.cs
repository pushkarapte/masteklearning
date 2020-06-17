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

class Solution {

    // Complete the organizingContainers function below.
    static string organizingContainers(int[][] container,int n) {
        int[] box = new int[n];
        int[] balls = new int[n];
        for(int i=0;i<n;i++)
    {
        for(int j=0;j<n;j++)
        {
            box[i]+=container[i][j];
            balls[i]+=container[j][i];
        }
    }

    Array.Sort(box); Array.Sort(balls);
    for(int i=0;i<n;i++)
    {
        if(balls[i]!=box[i])
        {
            return "Impossible";
            
        }
    }
    return "Possible";
}



    

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] container = new int[n][];

            for (int i = 0; i < n; i++) {
                container[i] = Array.ConvertAll(Console.ReadLine().Split(' '), containerTemp => Convert.ToInt32(containerTemp));
            }

            string result = organizingContainers(container,n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
