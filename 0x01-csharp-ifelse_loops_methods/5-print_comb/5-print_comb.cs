using System;

namespace _5_print_comb
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int x = 0; x < 100; x++)
			{
				if (x != 99)
				{
					Console.Write($"{x.ToString("00")}, ");
				}
				else
				{
					Console.Write($"{x}\n");
				}
			}
		}
	}
}
