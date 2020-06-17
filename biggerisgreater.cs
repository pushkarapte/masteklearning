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

    // Complete the biggerIsGreater function below.
    static string biggerIsGreater(string w) {
        char[] chars = w.ToCharArray();
        return nextPermutation(chars)
            ? new String(chars)
            : "no answer";
 }

  static bool nextPermutation(char[] array) {
        int i = getLastPeakIndex(array);
        if (i <= 0) 
            return false;

        int j = getReplacementIndex(array, i - 1);

        swap(array, i-1, j);

        
        j = array.Length - 1;
        while (i < j) {
            swap(array, i, j);
            i++;
            j--;
        }
        
        return true;
    }

    static int getLastPeakIndex(char[] chars){
        int i = chars.Length - 1;
        while (i > 0 && chars[i - 1] >= chars[i])
            i--;
        return i;
    }

    static int getReplacementIndex(char[] chars, int givenIndex){
        int i = chars.Length - 1;
        while (chars[i] <= chars[givenIndex])
            i--;
        return i;
    }

    static void swap(char[] chars, int a, int b){
        chars[a] ^= chars[b];
        chars[b] ^= chars[a];
        chars[a] ^= chars[b];
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine());

        for (int TItr = 0; TItr < T; TItr++) {
            string w = Console.ReadLine();

            string result = biggerIsGreater(w);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
