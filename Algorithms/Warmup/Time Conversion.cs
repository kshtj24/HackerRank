using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string timeConversion(string s) {
            string[] temp = s.Split(':');
            int hour = Convert.ToInt32(s.Split(':')[0]);

            if (s.Contains("AM"))
            {
                if (hour == 12)
                    return temp[0].Replace("12", "00") + ":" + temp[1] + ":" + temp[2].Replace("AM", "");
                else
                    return temp[0] + ":" + temp[1] + ":" + temp[2].Replace("AM", "");
            }
            else
            {
                if(hour == 12)
                    return temp[0] + ":" + temp[1] + ":" + temp[2].Replace("PM", "");
                else
                    return (hour+12).ToString() + ":" + temp[1] + ":" + temp[2].Replace("PM", "");
            }
//TODO One condition for 12 pm
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = timeConversion(s);
        Console.WriteLine(result);
    }
}
