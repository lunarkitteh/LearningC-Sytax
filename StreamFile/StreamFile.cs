using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
namespace StreamFile
{
    class MainClas
    {
        public static void Main(string[] args)
        {
            addItem ob = new addItem();
            readData ob2 = new readData();
            bool inMainMenu = true;
            while(inMainMenu){
				Console.WriteLine("1 - Add Item\n2 - Search Item\n>2 - Quit");
                int menu = int.Parse(Console.ReadLine());
                if(menu==1){
                    Console.Clear();
                    ob.addData();
                }
                else if(menu==2){
                    Console.Clear();
                    ob2.serachItem();
                }
                else if(menu>2){
                    Console.Clear();
                    Environment.Exit(0);
                }
            }

        }
    }

    public class addItem
    {
        string ID;
        string name;
        int quantity;
        int price;
        public void addData()
        {
            string fileName = "data.txt";
            if (!File.Exists(fileName))
            {
                using (StreamWriter writer = new StreamWriter("data.txt"))
                {
                    Console.Write("ID : ");
                    ID = Console.ReadLine();
                    Console.Write("Name : ");
                    name = Console.ReadLine();
                    Console.Write("Price : ");
                    price = int.Parse(Console.ReadLine());
                    Console.Write("Quantity : ");
                    quantity = int.Parse(Console.ReadLine());
                    writer.WriteLine("{0}\t{1}\t{2}\t{3}", ID, name, quantity, price);
                }
            }
            else
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    Console.Write("ID : ");
                    ID = Console.ReadLine();
                    Console.Write("Name : ");
                    name = Console.ReadLine();
                    Console.Write("Price : ");
                    price = int.Parse(Console.ReadLine());
                    Console.Write("Quantity : ");
                    quantity = int.Parse(Console.ReadLine());
                    sw.WriteLine("{0}\t{1}\t{2}\t{3}", ID, name, quantity, price);
                }
            }
        }
    }

    public class readData{
        public void serachItem()
        {
            using (StreamReader sr = new StreamReader("data.txt"))
            {

				string Line;
				while ((Line = sr.ReadLine()) != null)
				{
                    string pattern = @"\t+";
                    Regex rgx = new Regex(pattern);
					string[] result = rgx.Split(Line);
                    Console.WriteLine("Search item by:\n1 - ID\t>1 - name");
                    int subMenu = int.Parse(Console.ReadLine());
                    if(subMenu==1){
                        int id = int.Parse(Console.ReadLine());
                        if(result[0]==id.ToString()){
                            Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", result[0], result[1], result[2], result[3]);
                            return;
                        }
                        else{
                            Console.WriteLine("There's no item with ID of {0}",id);
                            return;
                        }
                    }
                    else if(subMenu>1){
                        string name = Console.ReadLine();
                        if(result[1].Contains(name)){
							Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}", result[0], result[1], result[2], result[3]);
                            return;
						}
						else
						{
							Console.WriteLine("There's no item with ID of {0}", name);
                            return;
						}
                    }
				}
            }
        }
    }
}