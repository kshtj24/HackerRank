using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Greedy
{
    class Priyanka_and_Toys
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wtoy = Array.ConvertAll((Console.ReadLine().Split(' ')), int.Parse);

            Console.WriteLine(numberOfUnits(n, wtoy));
        }
        static int numberOfUnits(int n, int[] wtoy)
        {
            Array.Sort(wtoy);
            int count = 1;
            int temp = wtoy[0];

            for (int i = 0; i < wtoy.Length; i++)
            {
                if (((temp + 4) - wtoy[i]) < 0)
                {
                    count++;
                    temp = wtoy[i];
                }

            }

            return count;
        }
    }
}
