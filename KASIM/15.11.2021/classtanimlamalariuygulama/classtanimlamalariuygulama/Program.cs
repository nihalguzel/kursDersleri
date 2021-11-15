using System;

namespace classtanimlamalariuygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 hesaplamaclassi = new Class1();
            ConsoleKeyInfo key = default(ConsoleKeyInfo);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("<-------------Hesap Makinesi--------------->");
                Console.WriteLine("1.Sayiyi Girin");
                int sayi1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("2.Sayiyi Girin");
                int sayi2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("İşlem Seçin + / * - ");
                key = Console.ReadKey(true);
                
                switch (key.Key)
                {
                    case ConsoleKey.Add:
                        Console.WriteLine("Toplama İşlemi Sonucu= " + hesaplamaclassi.toplama(sayi1, sayi2));
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Subtract:
                        Console.WriteLine("Çıkarma İşlemi Sonucu= " + hesaplamaclassi.cikarma(sayi1, sayi2));
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Multiply:
                        Console.WriteLine("Çarpma İşlemi Sonucu= " + hesaplamaclassi.carpma(sayi1, sayi2));
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Divide:
                        Console.WriteLine("Bölme İşlemi Sonucu= " + hesaplamaclassi.bolme(sayi1, sayi2));
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Tanımsız Bir İşlem Girdiniz");
                        Console.ReadKey();
                        break;
                }

            }



        }
    }
}
