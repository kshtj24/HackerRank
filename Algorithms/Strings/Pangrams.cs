using System;
using System.Collections.Generic;
using System.IO;

namespace Solution {
class Solution {
    static void Main(string[] args) 
	{
		String str = (Console.ReadLine()).ToLower();		
		Stack<char> container = new Stack<char>();
		
		foreach(char c in str)
		{
			if((c >= 97 && c<= 122) && !container.Contains(c))
				container.Push(c);
		}
		
		Console.WriteLine(container.Count == 26 ? "pangram": "not pangram");
    }
}
}
