using System;
class Program
{
	static void primeFactors(int n)
	{
		int c = 2;
		while (n > 1)
		{
			if (n % c == 0)
			{
				Console.Write(c + " ");
				n /= c;
			}
			else
				c++;
		}
	}
	
	public static int Main()
	{
		int n = 8;
		primeFactors(n);
		return 0;
	}
}

