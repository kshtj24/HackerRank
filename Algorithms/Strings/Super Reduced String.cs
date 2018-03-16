using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class SuperReducedString {

    static string super_reduced_string(string str){
        for (int i = 1; i < str.Length; i++) {
            if (str[i] == str[i-1]) {
                str = str.Substring(0, i-1) + str.Substring(i+1);
                i = 0;
            }
        }
        if (str.Length == 0) {
            return "Empty String";
        } else {
            return str;
        }
    }

    static void Main(String[] args) {
        string s = Console.ReadLine();
        string result = super_reduced_string(s);
        Console.WriteLine(result);
    }
}
