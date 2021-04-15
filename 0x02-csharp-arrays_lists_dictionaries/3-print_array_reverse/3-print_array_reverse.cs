using System;

class Array
{
	public static void Reverse(int[] array)
	{
		if (array == null)
			Console.WriteLine();
		else if (array.Length < 0)
			Console.WriteLine();
		else
		{
			for (int x = array.Length - 1; x >= 0; x--)
			{
				Console.Write(array[x]);
				if (x != 0)
					Console.Write(" ");
			}
			Console.WriteLine();
		}
	}

}