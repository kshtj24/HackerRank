using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Implementation
{
    class Sock_merchant
    {
        static int sockMerchant(int n, int[] ar)
        {
            var distinct = ar.Distinct();
            int sockPairs = 0;
            foreach (int i in distinct)
            {
                int count = ar.Where(element => element == i).Count();
                sockPairs += count / 2;
            }

            return sockPairs;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
        }
    }
}
