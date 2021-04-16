using System;
using System.Collections.Generic;

class LList
{
	public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
	{
		LinkedListNode<int> tmpNode;
		LinkedListNode<int> newNode = new LinkedListNode<int>(n);

		tmpNode = myLList.First;

		if (tmpNode == null)
		{
			myLList.AddFirst(newNode);
			return newNode;
		}

		while (tmpNode != null)
		{
			if (tmpNode.Next.Value < n)
				tmpNode = tmpNode.Next;
			else
			{
				myLList.AddAfter(tmpNode, newNode);
				break;
			}

		}
		return newNode;
	}
}