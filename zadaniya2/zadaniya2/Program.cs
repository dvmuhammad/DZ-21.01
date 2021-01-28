using System;

namespace zadaniya2
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.Write("Введите число: ");
			string operanD1 = Console.ReadLine();
			int operand1 = Int32.Parse(operanD1);
			Console.Write("Введите второе число: ");
			string operanD2 = Console.ReadLine();
			int operand2 = Int32.Parse(operanD2);
			Console.Write("+,-,*,/: ");
			string sign = Console.ReadLine();

			switch (sign)
			{
				case "+":
					{
						Console.WriteLine(operand1 + operand2);
						break;
					}

				case "-":
					{
						Console.WriteLine(operand1 - operand2);
						break;
					}

				case "*":
					{
						Console.WriteLine(operand1 * operand2);
						break;
					}

						
				default:
					{
						break;
					}

			}
			if (sign == "/")
			{
				if (operand2 == 0)
				{
					Console.WriteLine("ошибка");
				}
				else {
					Console.WriteLine(operand1 / operand2);

				}
			}
			Console.ReadKey();
		}
	}
}
