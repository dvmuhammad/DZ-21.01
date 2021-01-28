using System;

namespace zadaniya3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			byte a = Convert.ToByte(Console.ReadLine());
			if (a < 15) Console.WriteLine("[0 - 14]");
			else if (a < 36) Console.WriteLine("[15 - 35]");
			else if (a < 51) Console.WriteLine("[36 - 50]");
			else if (a < 101) Console.WriteLine("50 - 100]");

			Console.ReadKey();
		}
	}
}
