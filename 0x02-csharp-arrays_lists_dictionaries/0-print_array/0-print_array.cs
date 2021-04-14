using System;

class Array
{
	public static int[] CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}
		int[] result = new int[size];
		for (int x = 0; x < size; x++)
		{
			result[x] = x;
		}
		Console.WriteLine(String.Join(" ", result));
		return result;
	}
}