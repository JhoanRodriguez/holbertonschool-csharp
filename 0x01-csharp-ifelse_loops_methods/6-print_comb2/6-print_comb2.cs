using System;

namespace _6_print_comb2
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int x = 1; x < 90; x++)
			{
				if (x / 10 < x % 10)
				{
					if (x != 89)
						Console.Write($"{x.ToString("00")}, ");
					else
						Console.Write($"{x.ToString("00")}\n");
				}
			}
		}
	}
}