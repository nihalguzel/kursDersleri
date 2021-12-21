using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();
            Console.WriteLine(prg.metod2().ToString());
        }

        public void metod1()
        {
            metod2();
        }

        public int metod2()
        {
            int sayi = 15;
            return sayi;
        }
    }
}
