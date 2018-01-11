using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Implementation
{
    class Sherlock_and_Squares
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] range = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int ans = (int)Math.Floor(Math.Sqrt(range[1])) - (int)Math.Floor(Math.Sqrt(range[0] - 1));

                Console.WriteLine(ans);
            }
        }
    }
}
