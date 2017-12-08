using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Greedy
{
    class Sherlock_and_The_Beast
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(saveTheBeast(n));
            }

        }
        static string saveTheBeast(int n)
        {
            if (n < 3 || n == 4 || n == 7)
            {
                return "-1";
            }
            else
            {
                if (n % 3 == 0)
                {
                    return createString(n, 0);
                }

                if (n % 3 == 1)
                {
                    return createString(n - 10, 10);
                }

                if (n % 3 == 2)
                {
                    return createString(n - 5, 5);
                }
            }
            return "-1";
        }

        static string createString(int fives, int threes)
        {
            string s5 = new string('5', fives);
            string s3 = new string('3', threes);

            return s5 + s3;
        }
    }
}
