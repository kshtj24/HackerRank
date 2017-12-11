using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Greedy
{
    class Max_Min
    {
        static void Main(String[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            List<int> n_array = new List<int>();
            for (int i = 0; i < N; i++)
            {
                n_array.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine(minmax(n_array, K, N));
        }

        static int minmax(List<int> n_array, int k, int n)
        {
            int unfairness = int.MaxValue;

            n_array.Sort();

            for (int i = 0; i < n - k + 1; i++)
            {
                int temp = n_array[i + (k - 1)] - n_array[i];
                if (temp < unfairness)
                    unfairness = temp;
            }
            return unfairness;
        }
    }
}
