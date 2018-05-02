using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution {

    static int beautifulBinaryString(string b) {
        
            char[] str = b.ToCharArray();
            int count = 0;

            for(int i = 0; i <= str.Length - 3; i++)
            {
                string temp = str[i] + "" + str[i + 1] + "" + str[i + 2];
                if (temp.Equals("010"))
                {
                    str[i + 2] = '1';
                    count++;
                }
            }

            return count;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string b = Console.ReadLine();
        int result = beautifulBinaryString(b);
        Console.WriteLine(result);
    }
}
