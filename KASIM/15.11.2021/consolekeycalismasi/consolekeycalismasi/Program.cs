using System;

namespace consolekeycalismasi
{
    
    class Program
    {
        public readonly string c = "Tarih"; //Yalnızca okuma değeri yapacagımız değişkenler için kullanılır.
        int a = 5; // global değişken main dışında class içinde tanımlanır ve class içindeki tüm methodlar tarafından kullanılabilir class çağrılarak methodlar içinde kullanılabilir.
        static int f=3; //değişken static olarak tanımlanırsa class içindeki tüm methodlarda class cagrılmadan kullanılabilir.
        static void Main(string[] args)
        {

            int e = 6; //Local değişken yalnızca tanımlandığı method içinde kullanılır.

            goto sabittanımlama;

            string sifre = "";
            string mypass = "1234";
        tekrar:
            sifre = "";
            Console.WriteLine("Şifre Girin");
            ConsoleKeyInfo deger = default(ConsoleKeyInfo);
            

            do
            {
                deger = Console.ReadKey(true);

                if (deger.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }

                else if (deger.Key != ConsoleKey.Backspace && deger.Key != ConsoleKey.Enter)
                {
                    sifre += deger.KeyChar.ToString();
                    Console.Write("*");
                }
            }
            while (!(deger.Key == ConsoleKey.Enter));

            if (sifre == mypass)
            {
                Console.WriteLine("Giriş Başarılı");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Şifre Yanlış Tekrar Deneyin");
                Console.ReadKey();
                goto tekrar;
            }

        //Sabit değişken tanımlama const
        sabittanımlama:
            const int b = 0;// const ile tanımlanan değişkenler programın hiç bir yerinde değiştirilemez.
            Program deger1 = new Program();
            Console.WriteLine(deger1.c); // Yalnızca okunabilir değerler Clasın içinde main fonksiyonun dışında tanımlanır.

            
        }
    }
}
