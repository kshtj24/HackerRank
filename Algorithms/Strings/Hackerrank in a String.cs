using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string hackerrankInString(string s) {
        String str = "hackerrank";
            if (s.Length < str.Length)
            {
                return "NO";
            }
            int j = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (j < str.Length && s[i] == str[j])
                {
                    j++;
                }
            }
            return (j == str.Length ? "YES" : "NO");
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            string result = hackerrankInString(s);
            Console.WriteLine(result);
        }
    }
}
