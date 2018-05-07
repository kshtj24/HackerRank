using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int stringConstruction(string s) {
		int count = 0;
		string str = "";
		
		foreach(char c in s){
			if(!str.Contains(c))
				str += c;
		}
		
		return str.Length;
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            int result = stringConstruction(s);
            Console.WriteLine(result);
        }
    }
}
