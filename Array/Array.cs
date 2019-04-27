using System;
using System.Collections.Generic;
using System.IO;
namespace Assignment_Array
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool Continue = true;
            string[] NameArray = new string[10];  // 10 is the maximum number of name and price
            int[] Price = new int[10];
            int nomorKotak = 0;
            String Name = "";
            int Harga = 0;
            while (Continue)
            {

                Console.WriteLine("Main Menu : ");
                Console.WriteLine("1. Insert Product");
                Console.WriteLine("2. Shop");
                Console.WriteLine("3. Delete Product");
                Console.WriteLine("4. Quit");
                Console.Write("Pilihan : ");
                int Pilihan;
                while (!int.TryParse(Console.ReadLine(), out Pilihan))  // check if input is an integer
                {
                    Console.Write("The value must be of integer type, try again: ");
                }
                Console.Clear();
                if (Pilihan == 1)
                {
                    // NOTE : you can assign user input into an array this way - see some variables & arrays above
                    Console.Write("Product : ");
                    Name = Console.ReadLine();
                    Console.Write("Price : ");
                    Harga = int.Parse(Console.ReadLine());
                    NameArray[nomorKotak] = Name;
                    Price[nomorKotak] = Harga;
                    nomorKotak++;  // this value will be iterated/used when iterated by while loop above
                    Console.Clear();
                }
                else if (Pilihan == 4)
                {
                    Environment.Exit(1);
                }
                else if (Pilihan == 2)
                {
                    Console.WriteLine("No\tProducts\tPrice");
                    for (int i = 0; i < nomorKotak; i++)
                    {
                        Console.WriteLine("{0}\t{1}\t{2}", i, NameArray[i], Price[i]);
                    }
                    if ((Name == null || Harga == 0))
                    {
                        Console.WriteLine("There haven't been a product stocked yet");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.Write("Product's number : ");
                        int nomorBarang = int.Parse(Console.ReadLine());
                        Console.Write("Quantity : ");
                        int jumlah = int.Parse(Console.ReadLine());
                        int totalPrice = jumlah * Price[nomorBarang];
                        Console.WriteLine("Total price = {0}", totalPrice);
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                else if (Pilihan == 3)
                {
                    Console.WriteLine("No\tProducts\tPrice");
                    for (int i = 0; i < nomorKotak; i++)
                    {
                        Console.WriteLine("{0}\t{1}\t    {2}", i, NameArray[i], Price[i]);
                    }

                    Console.Write("Product to delete (product's number) : ");
                    int index = int.Parse(Console.ReadLine());
                    // remove specific index element of both arrays
                    var foos = new List<>(array);
                    foos.RemoveAt(index);
                    foos.ToArray();
                }
            }
        }
    }
}