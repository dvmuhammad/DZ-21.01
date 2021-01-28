using System;

namespace zadaniya6
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int a, b, c;
			a = Convert.ToInt32(Console.ReadLine());
			b = Convert.ToInt32(Console.ReadLine());
			c = Convert.ToInt32(Console.ReadLine());
			if (a > b && b > c && a > c)
			{
				Console.WriteLine($"{a} {b} {c}");
			}
			else if (a < b)
			{
				a = a + b;
				b = a - b;
				a = a - b;
				Console.WriteLine($"{a} {b} {c}");

			}
			else if (b< c)
			{
				b = b + c;
				c = b - c;
				b= b - c;
				Console.WriteLine($"{a} {b} {c}");
			}

			Console.ReadKey();
		}
	}
}
