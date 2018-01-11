using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Implementation
{
    class Find_Digits
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int count = 0;
                foreach (char c in n.ToString())
                {
                    if ((n % char.GetNumericValue(c)) == 0)
                        count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
