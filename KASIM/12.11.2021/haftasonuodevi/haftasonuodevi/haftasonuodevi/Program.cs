using System;

namespace haftasonuodevi
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();

            bool durum = false;

            Console.WriteLine("Hoşgeldinizi Giriş İçin Enter'a Basın");
            System.ConsoleKeyInfo gelenTus = Console.ReadKey(true);
            if (gelenTus.Key == ConsoleKey.Enter) {
                durum = true;
            }

            else
            {
                Console.WriteLine("\a");
                Console.Write("Tnaımsız Bir Tuşa Basıldı Giriş İçi Enter'a Basmalısınız");
            }

            while (durum)
            {
                Console.Clear();

                Console.WriteLine("Program Açıldı Çıkış İçin B Tuşunu Kullanabilirsiniz");

                Console.WriteLine("1-)Hesap Makinesi İçin H tuşuna basınız");

                System.ConsoleKeyInfo gelenPrg = Console.ReadKey(true);


                if (gelenPrg.Key == ConsoleKey.B)
                {
                    Console.WriteLine("Programdan Çıkılıyor");
                    durum =! durum;
                    break;
                }

                

                switch (gelenPrg.Key)
                {
                    case ConsoleKey.H:
                        prg.hesapmakinesi();
                        Console.ReadKey();
                        break;
                }
            }
        }

       public void hesapmakinesi()
        {
            double girilensayi1, girilensayi2, islemsonucu;
            string islem = "";

            Console.WriteLine("Sayı 1 Giriniz");
            girilensayi1 = Convert.ToDouble(Console.ReadLine()); //Consoledan sayı1'i aldık
            Console.WriteLine("Sayı 2 Giriniz");
            girilensayi2 = Convert.ToDouble(Console.ReadLine()); //Consoledan sayı2'i aldık

            Console.WriteLine("İsleminizi Seçin");
            System.ConsoleKeyInfo islemTus = Console.ReadKey(true);

            switch (islemTus.Key) //girilen islem değişkenini kontrol ediyoruz ve aşağıdaki durumlara geçiyoruz.
            {
                case ConsoleKey.Add: // eğer işlem + ise aşağıdaki kod bloğu çalışır.
                    islemsonucu = girilensayi1 + girilensayi2;
                    Console.WriteLine("Topalama Sonucu:" + islemsonucu);
                    break;
                case ConsoleKey.Subtract: // eğer girilen işlem - ise aşağıdaki kod bloğu çalışır.
                    islemsonucu = girilensayi1 - girilensayi2;
                    Console.WriteLine("Çıkarma Sonucu:" + islemsonucu);
                    break;
                case ConsoleKey.Multiply:
                    islemsonucu = girilensayi1 * girilensayi2;
                    Console.WriteLine("Çarpma Sonucu:" + islemsonucu);
                    break;
                case ConsoleKey.Divide:
                    islemsonucu = girilensayi1 / girilensayi2;
                    Console.WriteLine("Bölme Sonucu:" + islemsonucu);
                    break;
                default:
                    Console.WriteLine("Tanımsız İşlem Girildi");
                    break;
            }

        }
    }
}
