using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] solve(string[] a, string[] b){
        int[] result = new int[]{0,0};
        
        
        for(int i=0;i<3;i++)
        {
            int diff = int.Parse(a[i]) - int.Parse(b[i]);
            
            if(diff < 0 )
            {
                result[1] += 1;
            }
            else if(diff > 0)
            {
                result[0] +=1;
            }            
        }
        
        return result;
    }

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
       // int a0 = Convert.ToInt32(tokens_a0[0]);
       // int a1 = Convert.ToInt32(tokens_a0[1]);
       // int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
       // int b0 = Convert.ToInt32(tokens_b0[0]);
       // int b1 = Convert.ToInt32(tokens_b0[1]);
       // int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] result = solve(tokens_a0,tokens_b0);
        Console.WriteLine(String.Join(" ", result));
        

    }
}
