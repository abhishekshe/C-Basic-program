using System;
public class Program
{
	public int check(int n)
	{
		if (n % 2 == 0)
		{
			return 1;
		}
		else
		{
			return 0;
		}
	}

	public static void Main(string[] args)
	{
		int x, res;

		Console.Write("Enter a number:");
		x = Convert.ToInt32(Console.ReadLine());

		Program obj = new Program();
		res = obj.check(x);

		if (res == 1)
		{
			Console.WriteLine("Number is even:" + x);
		}
		else
		{
			Console.WriteLine("Number is odd:" + x);
		}
	}
}