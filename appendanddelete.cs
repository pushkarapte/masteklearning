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

    // Complete the appendAndDelete function below.
    static string appendAndDelete(string s, string t, int k) {
       
        if ((s.Length + t.Length) < k) 
            return "Yes"; 
      
        
        int commonLength = 0; 
        for (int i = 0; i < Math.Min(s.Length,  
                                t.Length); i++) 
        { 
            if (s[i] == t[i]) 
                commonLength++; 
            else
                break; 
        } 
      
      
        if ((k - s.Length - t.Length +  
                    2 * commonLength) % 2 == 0) 
            return "Yes"; 
      
       
        return "No"; 
      
           
       

    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string t = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine());

        string result = appendAndDelete(s, t, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
