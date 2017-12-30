using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int factorial = 1;
            while(number>1)
            {
                factorial *= number;
                number--;
            }
            Console.WriteLine(factorial);
        }
    }
}
