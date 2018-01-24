using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int lonelyinteger(int[] a) {
        int lonely_integer = -1;
        for(int i = 0; i < a.Length; i++)
        {
            int count = 0;
            for(int j = 0; j < a.Length; j++)
            {
               if(i != j && a[i] == a[j])
                   count++;
            }
            
            if(count == 0)
            {
                lonely_integer = a[i];
                break;
            }
        }
        return lonely_integer;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int result = lonelyinteger(a);
        Console.WriteLine(result);
    }
}
