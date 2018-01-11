using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Viral_Advertising
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int people = 5;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                people = (int) Math.Floor((decimal)people / 2);
                total += people;
                people *= 3;
            }
        }

    }
}
