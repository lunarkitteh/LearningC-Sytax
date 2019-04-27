using System;
namespace iDontKnow
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool inMainMenu = true;
            while (inMainMenu)
            {
                Console.WriteLine("################ Interplanetary Delivery Service ################");
                Console.WriteLine("1 - Log-in\n2 - Create a new account\n3 - Exit");
                string lineForTryParse = Console.ReadLine();
                int mainChoice;
                if (!int.TryParse(lineForTryParse, out mainChoice))
                {
                    Console.WriteLine("{0} is not an integer, please try again", mainChoice);
                }
                else if (mainChoice == 1)
                {
                    LogIn ob = new LogIn();
                }
                else if (mainChoice == 2)
                {

                }
                else if (mainChoice == 3)
                {
                    inMainMenu = false;
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}