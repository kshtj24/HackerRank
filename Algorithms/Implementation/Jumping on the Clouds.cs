using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Implementation
{
    class Jumping_on_the_Clouds
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] c_temp = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(c_temp, Int32.Parse);

            int jumps = 0;
            for (int i = 0; i < n; i++, jumps++)
            {
                if (i < n - 2 && c[i + 2] == 0) i++;
            }
            Console.WriteLine(jumps - 1);
        }
    }
}
