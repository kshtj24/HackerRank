using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        
        for(int i=1; i<=n;i++)
        {           
            
            for(int j = 0; j< n-i; j++)
            {
                Console.Write(" ");                
            }
            
            for(int j = 0; j < i; j++)
            {
                Console.Write("#");                
            }
            Console.WriteLine("");
        }
    }
}
