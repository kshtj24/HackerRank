using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Greedy
{
    class Mark_and_Toys
    {
        static int maxiumumToys(int[] prices, int k)
        {
            int numoftoys = 0;
            int i = 0;
            Array.Sort(prices);
            while (k >= prices[i])
            {
                k -= prices[i];
                numoftoys++;
                i++;
            }
            return numoftoys;
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] prices_temp = Console.ReadLine().Split(' ');
            int[] prices = Array.ConvertAll(prices_temp, Int32.Parse);
            int result = maxiumumToys(prices, k);
            Console.WriteLine(result);
        }
    }
}
