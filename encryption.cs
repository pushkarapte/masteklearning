using System;

class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();
        int Lmax = (int)Math.Ceiling(Math.Sqrt(s.Length));
        for(int i = 0; i < Lmax; i++){
            Console.Write(s[i]);
            for(int j = i+Lmax; j < s.Length; j+=Lmax){
                Console.Write(s[j]);
                }
            Console.Write(" ");
        }
    }
}
