using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Greedy
{
    class Marcs_Cakewalk
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] calories_temp = Console.ReadLine().Split(' ');
            int[] calories = Array.ConvertAll(calories_temp, Int32.Parse);

            Int64 miles = Int64.MaxValue;

            Array.Sort(calories);

            for (int j = calories.Length - 1; j >= 0; j--)
            {
                miles = miles - (calories[j] * (Int64)(Math.Pow(2, (calories.Length - 1) - j)));
            }
            Console.WriteLine(Int64.MaxValue - miles);
        }
    }
}
