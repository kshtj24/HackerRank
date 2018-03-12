using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Cipher
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split(' ');
            int N = Convert.ToInt32(line1[0]);
            int K = Convert.ToInt32(line1[1]);
            string S_temp = Console.ReadLine();
            int[] S = new int[N + K - 1];

            for (int i = 0; i < S_temp.Length; i++)
            {
                S[i] = Convert.ToInt32(S_temp[i]);
            }
            int[] O = new int[N];
            int sum = 0, j = 0, tempSum = 0, value = 0;
            for (int i = 0; i < N; i++)
            {
                if (i >= K)
                {
                    sum -= O[j++];
                }

                tempSum = sum + S[i];
                if (tempSum % 2 == 0)
                    value = 0;
                else
                    value = 1;

                sum += value;
                O[i] = value;
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(O[i]);
            }
        }
    }