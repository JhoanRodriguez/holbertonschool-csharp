using System;

class Character
{
	public static bool IsLower(char c)
	{
		if ('a' <= c && c <= 'z')
			return true;
		else
			return false;
	}
}