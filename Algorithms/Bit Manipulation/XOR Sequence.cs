using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class XORSequence {

	static long findResult(long L, long R)
	{
		return checkModuloBy8AndXor1ToN(L - 1) ^ checkModuloBy8AndXor1ToN(R);		
	}
	
	
	static long checkModuloBy8AndXor1ToN(long N)
	{
		long modulo = N % 8;
		switch(modulo)
		{
			case 0 : return N;
			case 1 : return N;
			case 2 : return 2;
			case 3 : return 2;
            case 4 : return N+2;
            case 5 : return N+2;
            case 6 : return 0;
            case 7 : return 0;
            
		}
        return 0;
	}
    static void Main(String[] args) {
        int Q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < Q; a0++){
            string[] tokens_L = Console.ReadLine().Split(' ');
            long L = Convert.ToInt64(tokens_L[0]);
            long R = Convert.ToInt64(tokens_L[1]);
			Console.WriteLine(findResult(L,R));
        }
    }
}
