using System;

namespace _14_rectangular_array
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] matrix = new int[5, 5];
			matrix[2, 2] = 1;
			for (int x = 0; x < 5; x++)
			{
				for (int y = 0; y < 5; y++)
				{
					if (y != 4)
						Console.Write($"{matrix[x, y]} ");
					else
						Console.Write($"{matrix[x, y]}");
				}
				Console.WriteLine();
			}
		}
	}
}
