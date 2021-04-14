using System;

namespace _3_print_alphabt
{
	class Program
	{
		static void Main(string[] args)
		{
			for (char x = 'a'; x <= 'z'; x++)
			{
				if (x != 'e' && x != 'q')
				{
					Console.Write(x);
				}
			}
		}
	}
}
