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

    // Complete the breakingRecords function below.
    static int[] breakingRecords(int[] scores) {
        var maxRecordBroken =0;
        var minRecordBroken =0;
        if(scores.Length>1)
        {
            var maxRecord = scores[0];
            var minRecord = scores[0];
        
        for(int i=1; i <scores.Length;i++)
        {
            if(scores[i] < minRecord)
            {
                minRecord = scores[i];
                minRecordBroken++;
            }
            if(scores[i] > maxRecord)
            {
                maxRecord = scores[i];
                maxRecordBroken++;
            }


        }
        }
        return new int[] {maxRecordBroken , minRecordBroken};


    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
        ;
        int[] result = breakingRecords(scores);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
