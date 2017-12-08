using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Implementation
{
    class Cats_and_a_Mouse
    {
        static void Main(String[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < q; a0++)
            {
                string[] tokens_x = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(tokens_x[0]);
                int y = Convert.ToInt32(tokens_x[1]);
                int z = Convert.ToInt32(tokens_x[2]);
                int temp = Math.Abs(z - x) - Math.Abs(z - y);
                if (temp > 0)
                    Console.WriteLine("Cat B");
                else if (temp < 0)
                    Console.WriteLine("Cat A");
                else
                    Console.WriteLine("Mouse C");
            }
        }
    }
}
