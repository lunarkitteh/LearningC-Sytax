using System;

namespace Sorting
{
	class MainClass
	{
		// get array input
		public void getArr(int[] arr, int numElement)
		{
			for (int i = 0; i < numElement; i++)
			{
				Console.Write("number : ");
				int number = int.Parse(Console.ReadLine());
				arr[i] = number;
			}
		}

		public void findMinMax(){
			Console.WriteLine("##### Smallest and Biggest Number #####");
			Console.Write("Number of elements : ");
			int numElement = int.Parse(Console.ReadLine());
			int[] arrx = new int[numElement];
			getArr(arrx, numElement);

				for (int i = 0; i < arrx.Length;i++){
				if (arrx[0] > arrx[i])    // to check if the arrx[0] is the smallest number
				{
					arrx[0] = arrx[i];   // if arrx[0] is not the smallest number than switch with arrx[i]
				}
				}
			Console.WriteLine("Smallest Number : " + arrx[0]);
			for (int i = 0; i < arrx.Length; i++)   // to check if arrx[0] is the biggest number
			{
				if (arrx[0] < arrx[i])
				{
					arrx[0] = arrx[i];  // if arrx[0]  is not the biggest number than switch withh arrx[i]
				}

			}
			Console.WriteLine("Largest Number : " + arrx[0]);

		}

		// Bubble sort
		public void BubbleSort()
		{
			// look up bubble sort algorithm in the algorithm app
			Console.WriteLine("##### Bubble Sort #####");
			Console.Write("1 - Show Result Only\n2 - Show Iterations Process\n");
			int subChoice = int.Parse(Console.ReadLine());
			Console.Clear();
			Console.Write("Number of elements : ");
			int elementNum = int.Parse(Console.ReadLine());
			int[] arr = new int[elementNum];
			getArr(arr, elementNum);
			int temporary;
			if (subChoice == 2)
			{
				// 'i' for loop to repeat sorting until all element is in a prefered sequence
				for (int i = 0; i < arr.Length; i++)
				{
					for (int j = 0; j < arr.Length - 1; j++)      // NOTE : (arr.Length-1) because the operation inside the for loop will only be executed until the arr.length-1 in this case 7
										      // due to the fact that the last element doesn't have the arr[i+1] value next to it
					{
						if (arr[j] > arr[j + 1])
						{
							temporary = arr[j];   // to temporarily hold the element of arr[j] so that it can b e assigned to arr[j+1]
							arr[j] = arr[j + 1];   // swaps the array elements
							arr[j + 1] = temporary;  // to assign the arr[j] element before it was swapped into arr[j+1]
						}
					}
					Console.WriteLine("Iteration results {0} :  ", i);
					for (int x = 0; x < arr.Length; x++)
					{
						Console.WriteLine(arr[x]);

					}
				}
			}

			else if (subChoice == 1)
			{
				for (int i = 0; i < arr.Length; i++)
				{
					for (int j = 0; j < arr.Length - 1; j++)

					{
						if (arr[j] > arr[j + 1])
						{
							temporary = arr[j];
							arr[j] = arr[j + 1];
							arr[j + 1] = temporary;
						}
					}
				}
				for (int x = 0; x < arr.Length; x++)
				{
					Console.WriteLine(arr[x]);

				}
			}
		}




		// Selection Sort
		public void SelectionSort()
		{
			Console.WriteLine("##### Selection Sort #####");
			Console.WriteLine("1 - Show Result Only\n2 - Show Iterations Process\n");
			int subChoice2 = int.Parse(Console.ReadLine());
			Console.Clear();
			Console.Write("Number of elements : ");
			int elementNum2 = int.Parse(Console.ReadLine());
			int[] arr2 = new int[elementNum2];
			getArr(arr2, elementNum2);
			if (subChoice2 == 1)
			{
				int temp = 0;
				int min;
				for (int i = 0; i < elementNum2; i++)
				{
					min = i;  // so that variable i can be used outside loop by assgining it's value into variable min
					for (int j = i+1; j < elementNum2; j++)
					{

						if(arr2[j]<arr2[i]){  // if arr2[j] is smaller than the number before it
							min = j;  // assign j to min
						}

					}
					temp = arr2[min]; 
					arr2[min] = arr2[i];
					arr2[i] = temp;

				}
				Console.WriteLine("The Array After Selection Sort is: ");
				for (int i = 0; i < elementNum2; i++)
				{
					Console.WriteLine(arr2[i]);
				}
			
			}

		}



		// Main
		public static void Main(string[] args)
		{
			MainClass ob = new MainClass();
			Console.WriteLine("########## SORTING ALGORITHMS ##########");
			bool cont = true;
			while (cont)
			{
				Console.Write("1 - Bubble Sort\n2 - Selection Sort\n3 - Smallest & Largest Number\n0 - Quit\n");
				int choice = int.Parse(Console.ReadLine());
				Console.Clear();
				if (choice == 1)
				{
					ob.BubbleSort();
				}
				else if (choice == 2)
				{
					ob.SelectionSort();
				}
				else if(choice==3){
					ob.findMinMax();
				}
				else if (choice == 0)
				{
					Environment.Exit(1);
				}
				else
				{
					Console.WriteLine("Your choice is unavailable, plase try again");
				}
				Console.WriteLine("Press any key to continue...");
				Console.ReadLine();
				Console.Clear();

			}
		}
	}
}
