using System;
using System.Collections.Generic;

class LList
{
	public static void Delete(LinkedList<int> myLList, int index)
	{

		LinkedListNode<int> strider = myLList.First;
		for (int i = 0; i < index && strider.Next != null; i++)
			strider = strider.Next;
		if (i == index)
			myLList.Remove(strider);
	}
}