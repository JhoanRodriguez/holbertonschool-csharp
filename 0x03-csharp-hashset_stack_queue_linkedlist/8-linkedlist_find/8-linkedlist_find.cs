using System;
using System.Collections.Generic;

class LList
{
	public static int FindNode(LinkedList<int> myLList, int value)
	{
		int counter = 0;

		if (!myLList.Contains(value))
			return -1;

		foreach (int x in myLList)
		{
			if (x == value)
				break;
			else
				counter += 1;
		}
		return counter;
	}
}