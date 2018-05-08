using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        calculateFraction(arr,n);
    }
    
    static void calculateFraction(int[] arr, int n)
    {
        float positiveCount = 0;
        float zeroCount = 0;
        float negativeCount = 0;
        
        foreach(int i in arr)
        {
            if(i > 0)
                positiveCount+=1;
            else if(i<0)
                negativeCount+=1;
            else
                zeroCount+=1;
        }
        Console.WriteLine(positiveCount/(float)n);
        Console.WriteLine(negativeCount/(float)n);
        Console.WriteLine(zeroCount/(float)n);
    }
}
