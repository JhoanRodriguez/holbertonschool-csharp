using System;
using System.Collections.Generic;

class List
{
	public static List<int> CreatePrint(int size)
	{
		if (size < 0)
		{
			Console.WriteLine("Size cannot be negative");
			return null;
		}
		List<int> results = new List<int>();
		for (int x = 0; x < size; x++)
			results.Add(x);
		Console.WriteLine(string.Join(" ", results));
		return results;
	}
}