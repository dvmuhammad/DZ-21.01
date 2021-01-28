using System;

namespace zadaniya1
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int a, b;
			a = Convert.ToInt32(Console.ReadLine());
			b = Convert.ToInt32(Console.ReadLine());
			if (a != b)
			{
				a = a + b;
				b = a;
				Console.WriteLine($"{a} {b}");
			}
			else
			{
				a = b = 0;
				Console.WriteLine($"{a} {b}");
			}
			Console.ReadKey();
		}     
	}
}
