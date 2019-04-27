using System;
namespace ClassAssignment
{
	public class Datas
	{
		public string name;
		public int age;
		public string adress;
		public void Input()
		{
			Console.WriteLine("Enter your name: ");
			name = Console.ReadLine();
			Console.WriteLine("Enter your city: ");
			adress = Console.ReadLine();
			Console.WriteLine("Enter your age: ");
			age = int.Parse(Console.ReadLine());
		}
	}
	public class Print
	{
		public static void print()
		{
            // Input() function is called here, instead of print() function being called in Input() function
            // because each variables is assigned with Console.ReadLine() which ask for user input,
            // if you call the print() function in the Input() function, the variables is not assigned yet,
            // you can do the latter by assigning each variable to a new one after getting user's input
			Datas ob = new Datas();
			ob.Input();
			Console.WriteLine("Name: {0}", ob.name);
			Console.WriteLine("City: {0}", ob.adress);
			Console.WriteLine("Age: {0}", ob.age);

		}
	}
}
