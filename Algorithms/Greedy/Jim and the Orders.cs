using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Greedy
{
    class Jim_and_the_Orders
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] orderNumber = new int[n];
            int[] totalOrderTime = new int[n];

            for (int i = 0; i < n; i++)
            {
                totalOrderTime[i] = (Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse)).Sum();
                orderNumber[i] = i + 1;
            }

            Array.Sort(totalOrderTime, orderNumber);
            Console.WriteLine(string.Join(" ", orderNumber));
        }
    }
}
