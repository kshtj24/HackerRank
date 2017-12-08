using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Implementation
{
    class Breaking_the_records
    {
        static int[] getRecord(int[] s)
        {
            int max = s[0];
            int min = s[0];
            int[] count = new int[2] { 0, 0 };

            foreach (int i in s)
            {
                if (i > max)
                {
                    max = i;
                    count[0]++;
                }
                else if (i < min)
                {
                    min = i;
                    count[1]++;
                }
            }
            return count;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] s_temp = Console.ReadLine().Split(' ');
            int[] s = Array.ConvertAll(s_temp, Int32.Parse);
            int[] result = getRecord(s);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
