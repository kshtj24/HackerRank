using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Implementation
{
    class The_Hurdle_Race
    {
        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] height_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(height_temp, Int32.Parse);
            Console.WriteLine(numberOfMagicPotions(n, k, height));
        }

        static int numberOfMagicPotions(int n, int k, int[] height)
        {
            int count = height.Max() - k;

            if (count > 0)
                return count;
            else
                return 0;
        }
    }
}
