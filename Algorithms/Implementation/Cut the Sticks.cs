using System;

class Cut_the_Sticks
{
    public static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        while (sum(arr) > 0)
        {
            int cut_made = minimum(arr);
            arr = cut_sticks(arr, cut_made);
        }

    }

    public static int[] cut_sticks(int[] arr, int cut)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0)
            {
                arr[i] -= cut;
                count++;
            }
        }
        Console.WriteLine(count);
        return arr;
    }

    public static int minimum(int[] arr)
    {
        int min = int.MaxValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min && arr[i] != 0)
                min = arr[i];
        }

        return min;
    }

    public static int sum(int[] arr)
    {
        int _sum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            _sum += arr[i];
        }

        return _sum;
    }
}