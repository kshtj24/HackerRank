using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Greedy
{
    class Luck_Balance
    {
        static void Main(String[] args)
        {
            int[] temp1 = Array.ConvertAll(Console.ReadLine().Split(' '), Int32.Parse);
            int n = temp1[0];
            int k = temp1[1];

            int[] contests = new int[n];
            int[] imp = new int[n];

          
            for (int j = 0; j < n; j++)
            {
                string[] temp = Console.ReadLine().Split(' ');
                contests[j] = int.Parse(temp[0]);
                imp[j] = int.Parse(temp[1]);
            }
            Array.Sort(contests, imp);
            int luck = contests.Sum();

            int importantones = 0;
            int havetowin = 0;

            foreach (int i in imp)
            {
                if (i == 1)
                {
                    importantones += 1;
                }
            }

            havetowin = importantones - k;

            for (int i = 0; i < havetowin; i++)
            {
                if (imp[i] == 1)
                {
                    luck -= (contests[i] * 2);
                }
                else
                {
                    havetowin++;
                }
            }

            Console.WriteLine(luck);

        }
    }
}
