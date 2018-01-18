using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] countingSort(int[] arr) {        
        for(int i=0;i<arr.Length;i++)
        {
            for(int j=0;j<arr.Length;j++)
            {
                if(arr[i] < arr[j])
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }        
        return arr;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        int[] result = countingSort(arr);
        Console.WriteLine(String.Join(" ", result));


    }
}
