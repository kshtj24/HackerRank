using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Greedy
{
    class Minimum_Absolute_Difference_in_an_Array
    {
        static int minimumAbsoluteDifference(int n, int[] arr)
        {
            int difference = Int32.MaxValue;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                try
                {
                    int x = Math.Abs(arr[i] - arr[i + 1]);

                    if (x < difference)
                        difference = x;
                }
                catch { }
            }
            return difference;

        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int result = minimumAbsoluteDifference(n, arr);
            Console.WriteLine(result);
        }
    }
}
