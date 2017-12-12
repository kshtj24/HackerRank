using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.Algorithms.Implementation
{
    class Chocolate_Feast
    {
        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int c = Convert.ToInt32(tokens_n[1]);
                int m = Convert.ToInt32(tokens_n[2]);

                int boughtChocolates = n / c; 
                int freeChocolates = 0;

                int wrappersReceived = boughtChocolates;
                while(wrappersReceived >= m)
                {
                    wrappersReceived -= m; //gave m wrappers back
                    freeChocolates++;      //got one more chocolate
                    wrappersReceived++;    //one chocolate means one more wrapper                    
                }

                Console.WriteLine(boughtChocolates + freeChocolates);
                
            }
        }
    }
}
