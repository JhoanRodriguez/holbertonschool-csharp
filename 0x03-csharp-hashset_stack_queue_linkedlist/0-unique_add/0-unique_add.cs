using System;
using System.Collections.Generic;

class List
{
	public static int Sum(List<int> myList)
	{
		HashSet<int> setList = new HashSet<int>(myList);
		int total = 0;

		foreach (int j in setList)
			total += j;

		return total;
	}
}