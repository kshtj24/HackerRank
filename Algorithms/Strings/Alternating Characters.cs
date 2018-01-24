using System;

class Alternating_characters
{
	public static void Main()
	{
		int T = int.Parse(Console.ReadLine());
		
		for(int t=0;t<T;t++)
		{
			string s = Console.ReadLine();
			int count = 0;
			for(int i = 1; i < s.Length; i++)
			{
				if(s[i].Equals(s[i - 1]))
					count++;
			}
			Console.WriteLine(count);
		}
	}
}