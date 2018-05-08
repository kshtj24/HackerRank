using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
       Console.WriteLine(solve(a,n));
    }
    static int solve(int[][] matrix ,int rank)
    {
        int sumDiagOne = 0;
        int sumDiagTwo = 0;
        
        for(int i=0;i<rank;i++)
        {
            sumDiagOne += matrix[i][i];
            
            sumDiagTwo += matrix[i][(rank-1) - i];
        }        
        return Math.Abs(sumDiagOne - sumDiagTwo);
    }
}
