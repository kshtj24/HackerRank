using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void insertionSort2(int n, int[] A) {
        var j = 0;
        for (var i = 1; i < A.Length; i++)
        {
            var value = A[i];
            j = i - 1;
            while (j >= 0 && value < A[j])
            {
                A[j + 1] = A[j];
                j = j - 1;
            }
            A[j + 1] = value;
            Console.WriteLine(string.Join(" ", A));
        }
        
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        insertionSort2(n, arr);
    }
}
