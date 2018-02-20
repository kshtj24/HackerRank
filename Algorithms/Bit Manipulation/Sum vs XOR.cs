using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Sum_vs_XOR{

    static long solve(long n) {
        long unset_bits=0;
        while (n > 0)
        {
            if ((n & 1) == 0)
                unset_bits++;
            n=n>>1;
        }
        return (long)Math.Pow(2, unset_bits);
    }

    static void Main(String[] args) {
        long n = Convert.ToInt64(Console.ReadLine());
        long result = solve(n);
        Console.WriteLine(result);
    }
}
