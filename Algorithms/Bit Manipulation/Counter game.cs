using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Counter_game
{

    static string counterGame(long n)
    {
        if (n == 1)
            return "Richard";
        else
        {
            return countSetBits(n - 1) % 2 == 0 ? "Richard" : "Louise";
        }
    }

    static long countSetBits(long n)
    {
        long count = 0;
        while (n > 0)
        {
            count += n & 1;
            n >>= 1;
        }
        return count;
    }

    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int a0 = 0; a0 < t; a0++)
        {
            long n = Convert.ToInt64(Console.ReadLine());
            string result = counterGame(n);
            Console.WriteLine(result);
        }
    }
}
