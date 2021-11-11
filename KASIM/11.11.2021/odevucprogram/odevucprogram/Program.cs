using System;

namespace odevucprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string secim = "";
            Program prg = new Program();

            Console.WriteLine("ÇOKLU PROGRAMA HOŞGELDİNİZ LÜTFEN AŞAĞIDAKİ LİSTEDEN İSTEDİĞİNİZ PROGRAMI SEÇİN");
            Console.WriteLine("1-BOY KİLO ENDEKSİ HESAPLAMA (E)");
            Console.WriteLine("2-HESAP MAKİNESİ (H)");
            Console.WriteLine("3-GEOMETRİK HESAPLAMALAR (G)");

            secim = Console.ReadLine();

            switch (secim)
            {
                case "E":
                    prg.boykiloendeksihesaplama();
                    break;
                case "H":
                    prg.hesapmakinesi();
                    break;
                case "G":
                    prg.geometrikhesaplama();
                    break;
            }


        }

        public void hesapmakinesi() {

            double girilensayi1, girilensayi2, islemsonucu;
            string islem = "";

            Console.WriteLine("Sayı 1 Giriniz");
            girilensayi1 = Convert.ToDouble(Console.ReadLine()); //Consoledan sayı1'i aldık
            Console.WriteLine("Sayı 2 Giriniz");
            girilensayi2 = Convert.ToDouble(Console.ReadLine()); //Consoledan sayı2'i aldık

            Console.WriteLine("İşlemi Giriniz");
            islem = Console.ReadLine();

            switch (islem) //girilen islem değişkenini kontrol ediyoruz ve aşağıdaki durumlara geçiyoruz.
            {
                case "+": // eğer işlem + ise aşağıdaki kod bloğu çalışır.
                    islemsonucu = girilensayi1 + girilensayi2;
                    Console.WriteLine("Topalama Sonucu:" + islemsonucu);
                    break;
                case "-": // eğer girilen işlem - ise aşağıdaki kod bloğu çalışır.
                    islemsonucu = girilensayi1 - girilensayi2;
                    Console.WriteLine("Çıkarma Sonucu:" + islemsonucu);
                    break;
                case "*":
                    islemsonucu = girilensayi1 * girilensayi2;
                    Console.WriteLine("Çarpma Sonucu:" + islemsonucu);
                    break;
                case "/":
                    islemsonucu = girilensayi1 / girilensayi2;
                    Console.WriteLine("Bölme Sonucu:" + islemsonucu);
                    break;
                default:
                    Console.WriteLine("Tanımsız İşlem Girildi");
                    break;
            }

        }

        public void boykiloendeksihesaplama()
        {

            string cinsiyet = "";
            double boy;
            double kilo;
            double hesaplamasonucu = 0;

        cinsiyetgirisi:
            Console.WriteLine("Lütfen Öncelikle Cinsiyetinizi Giriniz Erkek için E Kadın İçin K ");
            cinsiyet = Console.ReadLine();
            Console.WriteLine(cinsiyet);

            if (cinsiyet == "E")
            {

                goto boygirisi;
            }

            else if (cinsiyet == "K")
            {

                goto boygirisi;
            }

            else
            {
                Console.WriteLine("Tanımsız Bir Cinsiyet Girişi Yaptınız Lütfen Tekrar Girin");
                goto cinsiyetgirisi;

            }

        boygirisi:
            Console.WriteLine("Lütfen Boyuzunu Girin cm cinsinden");
            boy = Convert.ToDouble(Console.ReadLine());
            if (boy < 50)
            {
                Console.WriteLine("Tanımsız Bir değer girdiniz lütfen boyunuzu tekrar girin en az 50 değerini girebilirsiniz");
                goto boygirisi;
            }

            Console.WriteLine("Lütfen Kilonuzu cinsinden");
            kilo = Convert.ToDouble(Console.ReadLine());

            switch (cinsiyet)
            {
                case "E":
                    hesaplamasonucu = (kilo / (boy * boy)) * 10000;
                    break;

                case "K":
                    hesaplamasonucu = ((kilo / (boy * boy)) * 0.9) * 10000;
                    break;

            }


            if (hesaplamasonucu < 18.5)
            {
                Console.WriteLine("Hesaplanan Vücut Kitle Endeksiniz=" + hesaplamasonucu);
                Console.WriteLine("Bu Sonuca Göre Zayıfsınız");
            }

            else if (hesaplamasonucu >= 18.5 && hesaplamasonucu < 24.9)
            {
                Console.WriteLine("Hesaplanan Vücut Kitle Endeksiniz=" + hesaplamasonucu);
                Console.WriteLine("Bu Sonuca Göre Normalsiniz");
            }

            else if (hesaplamasonucu >= 24.9 && hesaplamasonucu < 29.9)
            {
                Console.WriteLine("Hesaplanan Vücut Kitle Endeksiniz=" + hesaplamasonucu);
                Console.WriteLine("Bu Sonuca Göre Kilolusunuz");
            }

            else
            {
                Console.WriteLine("Hesaplanan Vücut Kitle Endeksiniz=" + hesaplamasonucu);
                Console.WriteLine("Bu Sonuca Göre Obezsiniz");
            }

        }

        public void geometrikhesaplama()
        {

            int a, b = 0;
            Console.WriteLine("Hesaplama İşlemleri \n");
            Console.WriteLine("Lütfen Hesaplama Yapacağınız Programı Seçiniz");
            Console.WriteLine("Alan Hesabı A,Çevre Hesabı C ");
            Console.Write("Seçim ?");
            string secim = Console.ReadLine(); //Kullanıcının seçim değerini consoledan aldık.

            Console.WriteLine("Uzunluk Değerini Girin");
            a = Convert.ToInt32(Console.ReadLine()); //Kullanıcıdan a değerini consoledan aldık.
            Console.WriteLine("Genişlik Değerini Girin");
            b = Convert.ToInt32(Console.ReadLine()); //Kullanıcıdan b değerini consoledan aldık.

            switch (secim) //Kullanıcıdan aldığımız secim değerini Switch içinde A ve ya C mi diye kontrol ettik.
            {
                case "A": //Eğer seçim değişkeni A ise alttaki kod blogu çalışacak.
                    Console.WriteLine(a*b);   // Program clasında bulunan alan hesaplama fonksiyonunu çağırdık ve fonkisyona a ve b değerlerini parametre olarak gönderdik.
                    break;
                case "C": //Eğer seçim değişkeni C ise alttaki kod blogu çalışacak.
                    Console.WriteLine(2*a+2*b); //Program clasında bulunan cevrehesaplama fonksiyonu çağırdık ve fonksiyona a ve b değişkenlerini parametre olarak gönderdik.
                    break;
            }

        }
    }
}
