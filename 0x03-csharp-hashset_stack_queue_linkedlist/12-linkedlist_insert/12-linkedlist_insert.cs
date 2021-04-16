using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> newNode;
		LinkedListNode<int> tmpNode = new LinkedListNode<int>(n);

		newNode = myLList.First;

		while (newNode != null)
		{
			if (newNode.Next.Value < n)
				newNode = newNode.Next;
			else
			{
				myLList.AddAfter(newNode, tmpNode);
				break;
			}

		}
		return tmpNode;
	}
}