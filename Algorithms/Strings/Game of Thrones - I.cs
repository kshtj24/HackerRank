using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string gameOfThrones(string s){
		int xor = 0;
		foreach(char c in s){
			xor ^= c;
		}
		if((xor == 0) || (s.Contains((char)xor)))
			return "YES";
		return "NO";
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = gameOfThrones(s);
        Console.WriteLine(result);
    }
}
