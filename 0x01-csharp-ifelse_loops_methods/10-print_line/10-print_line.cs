using System;

class Line
{
	public static void PrintLine(int length)
	{
		if (length <= 0)
			Console.WriteLine();
		else
			Console.WriteLine(new String('_', length));
	}
}