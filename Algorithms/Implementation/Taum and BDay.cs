using System;

class Solution
{

    static long taumBday(long b, long w, long x, long y, long z)
    {
        x = (y + z < x) ? y + z : x;
        y = (x + z < y) ? x + z : y;

        return Math.Abs(b * x + w * y);
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_b = Console.ReadLine().Split(' ');
            long b = Convert.ToInt64(tokens_b[0]);
            long w = Convert.ToInt64(tokens_b[1]);
            string[] tokens_x = Console.ReadLine().Split(' ');
            long x = Convert.ToInt64(tokens_x[0]);
            long y = Convert.ToInt64(tokens_x[1]);
            long z = Convert.ToInt64(tokens_x[2]);
            long result = taumBday(b, w, x, y, z);
            Console.WriteLine(result);
        }
    }
}
