using System;
using System.Collections.Generic;
class List
{
	public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
	{
		List<int> newList = new List<int>();
		int number = 0;
		for (int i = 0; i < listLength; i++)
		{
			try
			{
				number = list1[i] / list2[i];
				newList.Add(number);
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("Cannot divide by zero");
				newList.Add(0);
			}
			catch (ArgumentOutOfRangeException)
			{
				Console.WriteLine("Out of range");
			}
		}
		return (newList);
	}
}