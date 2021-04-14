using System;

namespace _12_fizzbuzz
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int x = 1; x <= 100; x++)
			{
				if (x % 5 == 0 && x % 3 == 0)
					Console.Write("FizzBuzz ");
				else if (x % 3 == 0)
					Console.Write("Fizz ");
				else if (x % 5 == 0)
				{
					if (x != 100)
						Console.Write("Buzz ");
					else
						Console.Write("Buzz\n");
				}
				else
					Console.Write($"{x} ");
			}
		}
	}
}
