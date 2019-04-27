using System;

namespace OverrideFunction
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            sum.Sum(10, 20);
            sum.Sum(20.3901, 89.1829382);
            sum.Sum(234.123,145.890);
            sum.Sum("xx","yy");

            machine2 ob = new machine2();
            ob.car();
        }

        public static class sum{
            public static void Sum(int x,int y){
                Console.WriteLine("x+y="+(x+y));
            }
            public static void Sum(double x,double y){
                Console.WriteLine("x+y=" + (x + y));
            }
            public static void Sum(float x, float y){
                Console.WriteLine("x+y=" + (x + y));
            }
            public static void Sum(string x,string y){
                Console.WriteLine("x+y={0}{1}",x,y);
            }
        }

        public abstract class machine{
            public abstract void car();
        }
        public class machine2:machine{
            public override void car()
            {
                Console.WriteLine("Car");
            }
        }
    }
}
