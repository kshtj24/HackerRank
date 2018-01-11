using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank
{
    class Equalize_the_Array
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine(equalize(arr, n));
        }

        static int equalize(int[] arr, int n)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            foreach (int i in arr)
            {
                if (!map.ContainsKey(i))
                {
                    map.Add(i, 1);
                }
                else
                {
                    int value = 0;
                    map.TryGetValue(i, out value);
                    map[i] = value + 1;
                }
            }
            return n - map.Values.Max();
        }
    }
}
