using System;
// Implementing Binary and Linear search
namespace Walkthrough
{
	public class Search
	{
		public void AbsenceBased(int[] arr, int Absence)
		{
			int search;
			char[] Seat = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
			int min = 0;
			int max = (arr.Length) - 1;
			while (min <= max)
				{
					// example of binary search
				search = (min + max) / 2;
				Math.Round((double)(search));
				if (arr[search] == Absence)
				{
					// Uncomment Seat chars and assign each absence number to each seat's intilal/alphabets
					for (int i = 0; i < 26; i++)
					{
						// example of linear search
						if (i == search)
						{
							Console.WriteLine("Your seat is at chair " + Seat[i]);
							break;
						}
					}
					break;
				}
				else if (arr[search] < Absence)
				{
					min = search + 1;
				}
				else if (arr[search] > Absence)
				{
					max = search - 1;
				}
				else {
					Console.WriteLine("Your absence number is not available");
				}
			}

		}
	}


	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] Absences;
			Absences = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26 };
			Console.WriteLine("########## Binary Search (Seating Arrangement) #########");
			Console.WriteLine("Press 0 to exit");
			bool Continue = true;
			while (Continue)
			{
				Console.Write("Please enter your absence number : ");
				int AbsenceMain = Convert.ToInt32(Console.ReadLine());
				if (AbsenceMain == 0){
					
					Console.WriteLine("Running time (in big O notation) : O(log n)");
					Continue = false;
				}
				else
				{
					Search Object1 = new Search();
					Object1.AbsenceBased(Absences, AbsenceMain);
				}
			}
		}
	}
}