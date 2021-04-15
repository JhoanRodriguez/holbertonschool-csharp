﻿using System;
using System.Collections.Generic;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{
		LinkedList<int> newLinkedList = new LinkedList<int>();

		if (size < 0)
			return newLinkedList;

		for (int x = 0; x < size; x++)
			newLinkedList.AddLast(x);

		foreach (int x in newLinkedList)
			Console.WriteLine(x);

		return newLinkedList;
	}
}