using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Masukan Password=");
			SecureString hensin = GetConsoleSecurePassword();
			string password = new System.Net.NetworkCredential(string.Empty, hensin).Password;
			Console.WriteLine("your pass : {0}", password);
		}

		private static SecureString GetConsoleSecurePassword()
		{
			SecureString pwd = new SecureString();
			while (true)
			{
				ConsoleKeyInfo i = Console.ReadKey(true);
				if (i.Key == ConsoleKey.Enter)
				{
					break;
				}
				else if (i.Key == ConsoleKey.Backspace)
				{
					pwd.RemoveAt(pwd.Length - 1);
					Console.Write("\b \b");
				}
				else
				{
					pwd.AppendChar(i.KeyChar);
					Console.Write("*");
				}
			}
			return pwd;
		}
	}
}
