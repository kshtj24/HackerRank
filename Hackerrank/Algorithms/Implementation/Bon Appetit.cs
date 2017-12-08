using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Bon_Appetit
    {
        static string bonAppetit(int n, int k, int b, int[] ar)
        {
            int bActual = 0;
            for (int i = 0; i < n; i++)
            {
                if (i != k)
                    bActual += ar[i];
            }

            if (b == bActual / 2)
                return "Bon Appetit";
            else
                return (b - bActual / 2).ToString();
        }

        static void Main(String[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int b = Convert.ToInt32(Console.ReadLine());
            string result = bonAppetit(n, k, b, ar);
            Console.WriteLine(result);
        }
    }
}
