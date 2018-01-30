using System;

class Solution
{   
    static void Main(String[] args)
    {
		int[] expectedDate = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
		int[] returnDate = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
		
		int d1 = expectedDate[0];
		int m1 = expectedDate[1];
		int y1 = expectedDate[2];
		int d2 = returnDate[0];
		int m2 = returnDate[1];
		int y2 = returnDate[2];
		
		int fine = 0;
		if(y2 == y1 || y1 < y2){
			if(m2 == m1 || m1 < m2){
				if(d2 == d1 || d1 < d2){
					fine = 0;
				}
				else
					fine = (d1 - d2) * 15;
			}
			else
				fine = (m1 - m2) * 500;
		}
		else
			fine = 10000;
		Console.WriteLine(fine);
		}
}
