﻿using System;

class Program
{
	static void Main(string[] args)
	{
		Random rndm = new Random();
		int number = rndm.Next(-10, 10);
		if (number > 0)
		{
			Console.WriteLine("{0} is positive");
		}
		else if (number < 0)
		{
			Console.WriteLine("{0} is negative");
		}
		else
		{
			Console.WriteLine("{0} is zero");
		}
	}
}