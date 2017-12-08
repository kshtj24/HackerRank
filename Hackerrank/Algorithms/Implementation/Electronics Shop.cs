using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Electronics_Shop
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int s, int n, int m)
        {
            int result = -1;

            Array.Sort(keyboards);
            Array.Reverse(keyboards);
            Array.Sort(drives);

            for (int i = 0, j = 0; i < keyboards.Length; i++)
            {
                for (; j < m; j++)
                {
                    if (keyboards[i] + drives[j] > s)
                        break;
                    if (keyboards[i] + drives[j] > result)
                        result = keyboards[i] + drives[j];
                }
            }
            return result;
        }

        static void Main(String[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int n = Convert.ToInt32(tokens_s[1]);
            int m = Convert.ToInt32(tokens_s[2]);
            string[] keyboards_temp = Console.ReadLine().Split(' ');
            int[] keyboards = Array.ConvertAll(keyboards_temp, Int32.Parse);
            string[] drives_temp = Console.ReadLine().Split(' ');
            int[] drives = Array.ConvertAll(drives_temp, Int32.Parse);
            //  The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
            int moneySpent = getMoneySpent(keyboards, drives, s, n, m);
            Console.WriteLine(moneySpent);
        }
    }
}
