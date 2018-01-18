using System;

class Birthday_Chocolate
{

    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int[] tokens = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        int d = tokens[0];
        int m = tokens[1];

        int count = 0;
        for (int i = 0; i <= arr.Length - m; i++)
        {
            int sum = 0;
            for (int j = i; j < i + m; j++)
            {
                sum += arr[j];
            }

            if (sum == d)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}