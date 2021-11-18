using System;

namespace hesapmakinesi
{
    class Program
    {
        public static double sayi1 = 0;
        public static double sayi2 = 0;
        public static double sonuc = 0;
        public static string oprt;
        static void Main(string[] args)
        {
            Class1 clas = new Class1();
            clas.hesapmakinesi();
            Console.WriteLine("Sayi 1 Gir");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            git:
            Console.WriteLine("Sayi 2 Gir");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Operatör Gir");
            oprt = Console.ReadLine();

            switch (oprt)
            {
                case "+":
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine(sonuc);
                    sayi1 = sonuc;
                    goto git;
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine(sonuc);
                    sayi1 = sonuc;
                    goto git;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine(sonuc);
                    sayi1 = sonuc;
                    goto git;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine(sonuc);
                    sayi1 = sonuc;
                    goto git;
                    break;
                case "k":
                    Console.WriteLine("Program Kapandı");
                    break;
            }


            Console.WriteLine("Hello World!");
        }
    }
}
