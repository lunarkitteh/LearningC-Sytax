using System;

namespace Loop
{
	class MainClass
	{
		public void Asterisk1()
		{
			string[] Asterisk = { "*****", "****", "***", "**", "*" };
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(Asterisk[i]);
			}
		}
		public int Average(int num)
		{
			int Sum;
			int Total = 0;
			for (int i = 0; i < num; i++)
			{
				Console.Write("Number : ");
				Sum = int.Parse(Console.ReadLine());
				Total += Sum;
			}

			int Ave = Total / num;
			Console.WriteLine("Average : " + Ave);
			return Ave;
		}
		public String Reverse(String x)
		{
			String Reversed = "";
			char[] toChar = x.ToCharArray();
			for (int i = toChar.Length; i <= 0; i--)
			{
				Reversed += toChar[i];
			}
			return Reversed;
		}

		public void MulTable()
		{
			int n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= 10; i++)
			{
				for (int l = 1; l <= n; l++)
				{
					Console.WriteLine("{0}X{1}={2}", i, l, (n * i));
				}

			}
		}
		public void OddNum(int n)
		{
			int x;
			for (int i = 1; i <= n; i++)
			{
				x = i * 2 - 1;
				Console.WriteLine(x);
			}
		}
		public void NumTriangle(int x)
		{
			for (int i = 1; i <= x; i++){
				for (int j = 1; j <= i; j++)
				{
					Console.Write(j);
				}
				Console.WriteLine();
			}
		}
		public void AsteriskTriangle(int x)
		{
			for (int i = 1; i <= x; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
		public void NumTriangle2(int x)
		{
			for (int i = 0; i <= x; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write(i);
				}
				Console.WriteLine();
			}
		}
		public void NumTriangle3(int x)
		{
			int z = 1;  // to display the wanted number pattern 
						// outer loop to organize the number of rows
			for (int i = 1; i <= x; i++)
			{
				// inner loop to organize the number of column in each row
				for (int j = 1; j <= i; j++)
				{
					Console.Write("{0} ", z++);
				}
				Console.WriteLine();
			}
		}
		public void NumTriangle4(int x)
		{
			int z = 1;  // to display the wanted number pattern 
						// outer loop to organize the number of rows
			for (int i = 1; i <= x; i++)
			{
				// inner loop to organize space to create the shape wanted (space = x-i because the space is right before the "number" which will be printed by the next loop
				for (int space = x-i; space > 0; space--)
				{
					Console.Write(" ");
				}
				// inner loop to organize the number of column in each row
				for (int j = 1; j <= i; j++)
				{
					Console.Write("{0} ", z++);
				}
				Console.WriteLine();
			}
		}

		// March 2 2017 Assignment
		public void Assignment1()
		{
			int x = int.Parse(Console.ReadLine());
			for (int i = 0; i < x; i++)
			{
				for (int space = x - i; space > 0; space--)
				{
					Console.Write(" ");
				}
				for (int j = 0; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}

		public void DotsAndNumbers()
		{
			for (int row = 1; row <= 5; row++)
			{
				for (int dots = 4; dots >= row; dots--)
				{
					Console.Write(".");
				}
				for (int num = 0; num < row; num++)
				{
					Console.Write(row);
				}
				Console.WriteLine();
			}

		}


		//   Main
		public static void Main(string[] args)
		{
			MainClass ob = new MainClass();
		}
	}
}
