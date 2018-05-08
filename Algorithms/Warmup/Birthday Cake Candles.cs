using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int palindromeIndex(string s){
        if(isPalindrome(s))
			return -1;
		else
		{
			int xor = 0;
			foreach(char c in s)
			{
				xor ^= c;
			}
			return s.LastIndexOf((char)xor);
		}
    }
	
	static int isPalindrome(string s){
		int i =0;
		int j = s.Length - 1;
		
		while(i <= j)
		{
			int xor = s[i] ^ s[j];
			if(xor != 0)
				return false;
			
			i++;
			j--;
		}
		
		return true;
	}

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            int result = palindromeIndex(s);
            Console.WriteLine(result);
        }
    }
}
