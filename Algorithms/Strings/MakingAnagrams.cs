using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

  static int makingAnagrams(string s1, string s2)
    {
        int result = 0;

        for (int c = 97; c <= 122; c++)
        {
            result += Math.Abs(countOccurances(s1, (char)c) - countOccurances(s2, (char)c));
        }

        return result;
    }

    static int countOccurances(String str, char c)
    {
        int count = 0;
        foreach (char temp in str)
        {
            if (temp == c)
                count++;
        }

        return count;
    }

    static void Main(String[] args) {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        int result = makingAnagrams(s1, s2);
        Console.WriteLine(result);
    }
}
