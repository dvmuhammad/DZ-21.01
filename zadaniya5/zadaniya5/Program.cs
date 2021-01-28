using System;

namespace zadaniya5
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int a, b, c, d;
			a = Convert.ToInt32(Console.ReadLine());
			b = Convert.ToInt32(Console.ReadLine());
			c = Convert.ToInt32(Console.ReadLine());
			d = Convert.ToInt32(Console.ReadLine());
			if (a < b && c < d && b < c && b < d)
			{
				Console.WriteLine("Числа расположены по возрастанию");
			}
			else if (a == b && c == d && b == c && b == d)
			{
				Console.WriteLine(a * b * c * d);
			}
			else if (a < b && a < c && a < d)
			{
				Console.WriteLine($"Min:{a}");
			}
			else if (b < a && b < c && b < d)
			{
				Console.WriteLine($"Min:{b}");
			}
			else {
				int m = Math.Min(c, d);
				Console.WriteLine($"Min:{m}");
			}

			Console.ReadKey();
		}
	}
}
