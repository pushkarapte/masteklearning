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

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        decimal positives =0;
        decimal negatives =0;
        decimal zeros =0;
        decimal length = arr.Length;
        for(int i=0;i<length;i++)
        {
            if(arr[i]<0) negatives++;
            else if(arr[i]>0) positives++;
            else zeros++;
        }
          Console.WriteLine(positives / length);
          Console.WriteLine(negatives / length);
          Console.WriteLine(zeros / length);

        
  

    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}
