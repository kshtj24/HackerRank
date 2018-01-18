using System;

class Drawing_Book
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int from_front = p / 2;
        int from_back = n / 2 - p / 2;

        Console.WriteLine(from_front >= from_back ? from_back : from_front);
    }
}