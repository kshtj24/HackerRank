using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Greedy
{
    class Maximum_Perimeter_Triangle
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] temp = Console.ReadLine().Split(' ');
            int[] sides = Array.ConvertAll(temp, int.Parse);
            Console.WriteLine(largestPerimeter(n, sides));
        }

        static string largestPerimeter(int n, int[] sides)
        {
            Array.Sort(sides);
            Array.Reverse(sides);

            for (int i = 0; i < (n - 2); i++)
            {
                if (sides[i] < sides[i + 1] + sides[i + 2])
                {
                    return (sides[i + 2] + " " + sides[i + 1] + " " + sides[i]);
                }
            }
            return "-1";
        }
    }
}
