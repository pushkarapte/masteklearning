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

    // Complete the viralAdvertising function below.
    static int viralAdvertising(int n) {
        var totalLikes = 0D;
        var adShareCount = 5.0;
      
        for(int i=0; i < n ;i++)
        {
            totalLikes += Math.Floor(adShareCount / 2 );
            adShareCount = Math.Floor(adShareCount / 2 )* 3;
                 
}
        return Convert.ToInt32(totalLikes);

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int result = viralAdvertising(n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
