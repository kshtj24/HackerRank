using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Strings
{
    class CamelCase
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string[] split = Regex.Split(s, @"(?<!^)(?=[A-Z])");
            Console.WriteLine(split.Length);
        }
    }
}
