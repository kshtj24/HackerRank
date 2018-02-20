using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class The_Great_XOR {

    static long theGreatXor(long x){
        long result = 0;
        int position = 0;
        while(x > 0) 
        {
            if((x&1) == 0) 
            {
                result += (1L<<position);
            }
            position++;
            x >>= 1;
        }
    return result;
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            long x = Convert.ToInt64(Console.ReadLine());
            long result = theGreatXor(x);
            Console.WriteLine(result);
        }
    }
}
