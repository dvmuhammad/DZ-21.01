using System;

namespace zadaniya4
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int a;
			a = Convert.ToInt32(Console.ReadLine());
			if (a >= 500) Console.WriteLine(a - (a * 3) / 100);
			else if (a > 1000) Console.WriteLine(a - (a * 5) / 100);
			else if (a < 500) Console.WriteLine(a);
			Console.ReadKey();
			                                  
		}
	}
}
