using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Implementation
{
    class Repeated_String
    {
        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            long n = Convert.ToInt64(Console.ReadLine());

            long count = 0;
            long extraChars = n % s.Length;
            long times = n / s.Length;

            foreach (char c in s)
            {
                if (c.Equals('a'))
                    count += times;
            }

            for (int i = 0; i < extraChars; i++)
            {
                if (s[i].Equals('a'))
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
