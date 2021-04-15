using System;
using System.Collections.Generic;


class List
{
	public static List<int> CommonElements(List<int> list1, List<int> list2)
	{

		HashSet<int> hSet1 = new HashSet<int>(list1);
		HashSet<int> hSet2 = new HashSet<int>(list2);

		hSet1.IntersectWith(hSet2);
		list1.Clear();
		foreach (int x in hSet1)
			list1.Add(x);

		list1.Sort();

		return list1;
	}
}