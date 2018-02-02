using System;
using System.Collections.Generic;
using System.IO;

class Solution
{

    static int[] countingSort(int[] arr)
    {
        List<int> result = new List<int>();

        for (int i = 0; i <= 99; i++)
        {
            int count = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == i)
                {
                    count++;
                }
            }

            result.Add(count);
        }

        return result.ToArray();
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        int[] result = countingSort(arr);
        Console.WriteLine(String.Join(" ", result));
    }

}
