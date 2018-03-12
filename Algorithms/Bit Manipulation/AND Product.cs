using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static long andProduct(long a, long b) {
        long andResult = a;
        for(long i = a+1; i <=b; i++){
            andResult &= i;
        }
        return andResult;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < n; a0++){
            string[] tokens_a = Console.ReadLine().Split(' ');
            long a = Convert.ToInt64(tokens_a[0]);
            long b = Convert.ToInt64(tokens_a[1]);
            long result = andProduct(a, b);
            Console.WriteLine(result);
        }
    }
}
