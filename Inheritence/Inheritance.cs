using System;

namespace Inheritence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("########## Euclid Algorithm - finding greatest common devisor ##########");
            commonDevisor ob = new commonDevisor();
            bool inMainMenu = true;
            while (inMainMenu)
            {
                Console.WriteLine("x1 = user's input\nx=1 - new calculation\nx>1 - quit");
                Console.Write("x1 : ");
                int inputMain = int.Parse(Console.ReadLine());
                if (inputMain == 1)
                {
                    ob.EuclidAlgorithm();
                }
                else if (inputMain > 1)
                {
                    Environment.Exit(0);
                }
            }
        }
    }

    public class integers
    {
        private int x;
        private int y;
        public void getValues()
        {
            Console.Write("m = ");
            x = int.Parse(Console.ReadLine());
            Console.Write("n = ");
            y = int.Parse(Console.ReadLine());

			// even without interchange m & n value if m is smaller than n, the algorithms will always proceed to interchange them
			// e.g when 2%5 :
			// !!  2 divided by 5 (integer division) is 0 with a remainder of 2.
			// 2 = 0 x 5 + 2
			// ### and 
			// 22  % 5 = 2 
			// 17 % 5 = 2
			// 12 % 5 = 2
			// 7 % 5 = 2
			// 2 % 5 = 2
			// ### and
			/*
             * 22 / 5 = 4 + 2/5
             * 17 / 5 = 3 + 2/5
             * 12 / 5 = 2 + 2/5
             * 7  / 5 = 1 + 2/5
             * 2  / 5 = 0 + 2/5
             */
			// But it will reduce the running time
			if (x < y)
			{
				int temp = x;
				x = y;
				y = temp;
			}

		}
        public int privX
        {
            get { return x; }
            set { x = value; }
        }
        public int privY
        {
            get { return y; }
            set { y = value; }
        }
    }

    public class commonDevisor : integers
    {
        public void EuclidAlgorithm()
        {
            Console.Clear();
            bool not0 = true;
            int r;
            Console.WriteLine("x2 = user's input\nx=1 - show process\nx>1 - show result");
			Console.Write("x2 : ");
            int subMenu = int.Parse(Console.ReadLine());
            if (subMenu == 1)
            {
                getValues();
                int i = 1;
                while (not0)
                {
                    r = privX % privY;
                    if (r != 0)
                    {
                        Console.WriteLine("Iteration {0}\nm = {1}\nn = {2}\nr = {3}", i, privX, privY, r);
                        Console.WriteLine("----------------------------------------");
                        privX = privY;
                        privY = r;
                        i++;
                    }
                    else if ((r == 0) && (i == 0))
                    {
                        Console.WriteLine("{0}%{1}=0", privX, privY);
                        Console.WriteLine("Greatest common devisor: " + privY);
                        break;
                    }
                    else if ((i > 0) && (r == 0))
                    {
                        Console.WriteLine("Iteraion : " + i);
                        Console.WriteLine("{0}%{1}=0", privX, privY);
                        Console.WriteLine("Greatest common devisor: " + privY);
                        break;
                    }
                }
            }
            else if (subMenu > 1)
            {
                while (not0)
                {
                    r = privX % privY;
                    if (r != 0)
                    {
                        privX = privY;
                        privY = r;
                    }
                    else if(r==0){
                        Console.WriteLine("Greatest common devisor: " + privY);
                        break;
                    }
                }
            }
        }
    }
}


