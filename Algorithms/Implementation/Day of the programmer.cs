using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string solve(int year){
        if (year == 1918)
            return "26.09.1918";
        else if (((year <= 1917) && (year%4 == 0)) || (year%400 == 0) || ((year%4 ==0) && (year%100 != 0)))
            return "12.09." + year.ToString();
        else
            return "13.09." + year.ToString();
    }

    static void Main(String[] args) {
        int year = Convert.ToInt32(Console.ReadLine());
        string result = solve(year);
        Console.WriteLine(result);
    }
}
