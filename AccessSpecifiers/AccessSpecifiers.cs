using System;
public class x{
  public static void Main(string[] args){
        priv ob = new priv();
        ob.printMethod2();
    }
}

// USING PRIVATE VARIABLES
class priv{
    private int a = 100;
    private int b = 222;
    
    // METHOD 1
    public void SumMethod1(){
        int z = a;
        int y = b;
        Console.WriteLine("sum : "+(z+y));
    }
    
        // METHOD 2
        public int privX
        {
            get { return a; }
            set { a = value; }
        }
        public int privY
        {
            get { return b; }
            set { b = value; }
        }
        public void printMethod2(){
        Console.WriteLine("sum : "+(privX+privY));
        }
    
}