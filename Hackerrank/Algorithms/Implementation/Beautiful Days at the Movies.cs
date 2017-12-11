using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Implementation
{
    class Beautiful_Days_at_the_Movies
    {
        static void Main(String[] args)
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            int i = input[0];
            int j = input[1];
            int k = input[2];
            int count = 0;
            for (int e = i; e <= j; e++)
            {
                if (Math.Abs(e - reverse(e)) % k == 0)
                    count++;
            }
            Console.WriteLine(count);

        }
        static int reverse(int value)
        {
            int reverse = 0;

            while (value > 0)
            {
                int remainder = value % 10;
                reverse = reverse * 10 + remainder;
                value = value / 10;
            }

            return reverse;
        }
    }
}
