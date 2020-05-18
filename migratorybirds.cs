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

    // Complete the migratoryBirds function below.
    static int migratoryBirds(List<int> arr) {
        List<int> sightings = new List<int> {0,0,0,0,0};
        for(int i=0; i < arr.Count ; i++)
                {
                        sightings[(arr[i]) - 1] = sightings [(arr[i] - 1)] + 1;
                }

                int indexOfMaxValue = 0;
                 for (int i=0; i<sightings.Count; i++)
                {
                        if (sightings[i] > sightings[indexOfMaxValue])
                        {
                                indexOfMaxValue  = i;
                        }
                 }
                return indexOfMaxValue + 1;

        }


    

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
