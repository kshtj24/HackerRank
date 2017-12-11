using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Greedy
{
    class Greedy_Florist
    {
        static int getMinimumCost(int n, int k, List<int> c)
        {
            int modulo = c.Count % k;
            int finalCost = 0;
            int x = 0;
            int y = (c.Count - modulo) / k;

            c.Sort();
            c.Reverse();

            for (x = 0; x < y; x++)
            {
                finalCost += (x + 1) * (c.Take(k).Sum());
                c.RemoveRange(0, k);
            }

            if (c.Count > 0)
            {
                finalCost += (x + 1) * (c.Take(modulo).Sum());
            }

            return finalCost;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);
            int minimumCost = getMinimumCost(n, k, c.ToList());
            Console.WriteLine(minimumCost);
        }
    }
}
