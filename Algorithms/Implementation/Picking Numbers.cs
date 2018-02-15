using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int pickingNumbers(int[] a) {
        int sum = 0; 
        for(int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        
        int average = sum / a.Length;        
        
        int count = 0;
        
        for(int i = 0; i < a.Length; i++)
        {
            if(Math.Abs(average - a[i]) <= 1)
                count++;
        }
        
        return count;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int result = pickingNumbers(a);
        Console.WriteLine(result);
    }
}
