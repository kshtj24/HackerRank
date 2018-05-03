using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static int gemstones(string[] arr)
    {
        HashSet<char> minerals = new HashSet<char>(arr[1].ToCharArray());

        foreach (string s in arr)
        {
            minerals.IntersectWith(new HashSet<char>(s.ToCharArray()));
        }

        return minerals.Count;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];
        for (int arr_i = 0; arr_i < n; arr_i++)
        {
            arr[arr_i] = Console.ReadLine();
        }
        int result = gemstones(arr);
        Console.WriteLine(result);
    }
}
