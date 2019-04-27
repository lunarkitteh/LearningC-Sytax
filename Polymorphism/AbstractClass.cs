using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
                c.tambah();
        }
        abstract class Hitung
        {
            public int angka = 7;
            public abstract void tambah();
        }
        class Calculator : Hitung
        {
            public override void tambah()
            {
                Console.WriteLine("tambah :" + angka*angka);
            }
 
        }
 
    }
}