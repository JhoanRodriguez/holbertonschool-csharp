using System;
using System.Collections.Generic;

class List
{
	public static List<bool> DivisibleBy2(List<int> myList)
	{
		List<bool> results = new List<bool>();
		foreach (int x in myList)
		{
			if (x % 2 == 0)
				results.Add(true);
			else
				results.Add(false);
		}
		return results;
	}
}