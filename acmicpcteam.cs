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

    // Complete the acmTeam function below.
    static int[] acmTeam(string[] topic) {
          int count = 1, max = int.MinValue;
        for(int i=0; i < topic.Length-1; i++){
            for(int j = i+1; j < topic.Length; j++){
                int temp = 0;
                for(int k = 0; k < topic[i].Length; k++)
                    if(topic[i][k] == '1' || topic[j][k] == '1')
                        temp++;
                if (temp > max){
                    max = temp;
                    count = 1;
                }
                else if (temp == max)
                    count++;
            }
        }
        int[] arr = {max, count};
        return arr;
    }

        



    

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        string[] topic = new string [n];

        for (int i = 0; i < n; i++) {
            string topicItem = Console.ReadLine();
            topic[i] = topicItem;
        }

        int[] result = acmTeam(topic);

        textWriter.WriteLine(string.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
