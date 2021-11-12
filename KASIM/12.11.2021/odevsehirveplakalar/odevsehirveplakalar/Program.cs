using System;

namespace odevsehirveplakalar
{
    class Program
    {
        
        static void Main(string[] args)
        {

            goto metodlukeycalismasi;
            int plaka;
            string sehir = "";

            Console.WriteLine("Şehir Giriniz");
            sehir = Console.ReadLine();
            Console.WriteLine("Plaka Giriniz");
            plaka = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= plaka; i++)
            {
                Console.WriteLine(sehir);

            }

            Program prg = new Program();

            Console.WriteLine("Genişlik :");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kalınlık :");
            double k = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Uzunluk :");
            double u = Convert.ToDouble(Console.ReadLine());

            double sonuc = (g * k * u) / (prg.hesap());
            double tutar = (sonuc * (prg.fiyat()));
            Console.WriteLine(sonuc);
            Console.WriteLine(tutar);

        ivmehesaplama:
            //İVME HESAPLAMA ÇALIŞMASI
            Program prg1 = new Program();
            Console.WriteLine("İlk Hız Girin");
            double ilkhiz = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Son Hız Girin");
            double sonhiz = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Süre Girin");
            double sure = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hesaplanan İvme"+(prg1.ivmehesapla(ilkhiz, sonhiz, sure)));

        //Son Hız - İlk Hız / Süre
        indexliverialma:

            //Değişken Dizisi Olarak Çağırma
            int sayi = 15;
            string isim= "Burak";
            double yas = 30.9;

            Console.WriteLine(sayi + " " + isim + " " + yas + "");
            Console.WriteLine("İsim:{0} Sayi:{1} Yas:{2}", isim,sayi,yas);//değişkenler dizi olarak tutulduğu için bu şekildede kullanılabilir.

            Console.Write("Ad Giriniz");
            string ad = Console.ReadLine();
            Console.Write("SoyAd Giriniz");
            string soyad = Console.ReadLine();
            Console.Write("Yaş Giriniz");
            int yas1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adınız:{0}\nSoyadınız{1}\nYasiniz{2}", ad, soyad, yas1);

            //Değişken Dizisi Olarak Çağırma Sonu

            //Consoledan Gelen Tuşlara Göre İşlem Yapma
            keyalma:

            System.ConsoleKeyInfo KeyInfo = Console.ReadKey(true);//klavyeden gelen değeri KeyInfo değişkenine aktardık.
            Console.WriteLine(KeyInfo.Key);// KeyInfo içindeki Key değerini yazdırdık

            if (KeyInfo.Key == ConsoleKey.Escape) //KeyInfo içindeki Key değeri Escape e eşitse aşağıdaki kod bloğu çalışacak.
            {
                Console.WriteLine("ESC YE BASILD");
            }

            else
            {
                Console.WriteLine("Yanlış Tuşa Bastınız");
            }

        keyalmacalismasi:
            while (true) {
            
            Console.WriteLine("SEÇİM İÇİN BİR TUŞA BASIN \n H=>HESAP MAKİNESİ \n G=>GEOMETRİK HESAPLAMA \n B=>BOY KİLO ENDEKSİ \n");
                System.ConsoleKeyInfo girilentus1 = Console.ReadKey(true);
                Console.Clear();
             if (girilentus1.Key == ConsoleKey.H) //KeyInfo içindeki Key değeri Escape e eşitse aşağıdaki kod bloğu çalışacak.
            {
                Console.WriteLine("HESAP MAKİNESİ AÇILDI");
            }
            else if (girilentus1.Key == ConsoleKey.G) //KeyInfo içindeki Key değeri Escape e eşitse aşağıdaki kod bloğu çalışacak.
            {
                Console.WriteLine("GEOMETRİK HESAPLAMA AÇILDI");
            }
            else if (girilentus1.Key == ConsoleKey.B) //KeyInfo içindeki Key değeri Escape e eşitse aşağıdaki kod bloğu çalışacak.
            {
                Console.WriteLine("BOY KİLO ENDEKSİ HESAPLAMA AÇILDI");
            }
            else
            {
                Console.WriteLine("TANIMSIZ BİR GİRİŞ YAPTINIZ PROGRAMDAN ÇIKILIYOR");
                    break;
            }
            
            }
            //Consoledan Gelen Tuşlara Göre İşlem Yapma Sonu
            metodlukeycalismasi:
            
            Program prg2 = new Program();

            


            while (true) {
                
             Console.Clear();
             Console.WriteLine("ÇOKLU PROGRAMA HOŞGELDİNİZ LÜTFEN AŞAĞIDAKİ LİSTEDEN İSTEDİĞİNİZ PROGRAMI SEÇİN");
             Console.WriteLine("1-BOY KİLO ENDEKSİ HESAPLAMA (E)");
             Console.WriteLine("2-HESAP MAKİNESİ (H)");
             Console.WriteLine("3-GEOMETRİK HESAPLAMALAR (G)");
             
             System.ConsoleKeyInfo girilentus = Console.ReadKey(true);

            
            switch (girilentus.Key)
            {
                case ConsoleKey.E:
                    prg2.boykiloendeksihesaplama();
                    break;
                case ConsoleKey.H:
                    prg2.hesapmakinesi();
                    break;
                case ConsoleKey.G:
                    prg2.geometrikhesaplama();
                    break;
                default:
                    Console.WriteLine("\a");
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

    public void geometrikhesaplama() {

            int a, b = 0;
            double c = 0;
            double p = 3.14;
            Console.WriteLine("Hesaplama İşlemleri \n");
            Console.WriteLine("Lütfen Hesaplama Yapacağınız Programı Seçiniz");
            Console.WriteLine("Alan Hesabı A,Çevre Hesabı C,Daire Alanı D,Daire Çevresi DC");
            Console.Write("Seçim ?");
            string secim = Console.ReadLine(); //Kullanıcının seçim değerini consoledan aldık.



            switch (secim) //Kullanıcıdan aldığımız secim değerini Switch içinde A ve ya C mi diye kontrol ettik.
            {
                case "A": //Eğer seçim değişkeni A ise alttaki kod blogu çalışacak.
                    Console.WriteLine("Uzunluk Değerini Girin");
                    a = Convert.ToInt32(Console.ReadLine()); //Kullanıcıdan a değerini consoledan aldık.
                    Console.WriteLine("Genişlik Değerini Girin");
                    b = Convert.ToInt32(Console.ReadLine()); //Kullanıcıdan b değerini consoledan aldık.
                    Console.WriteLine(a * b);   // Program clasında bulunan alan hesaplama fonksiyonunu çağırdık ve fonkisyona a ve b değerlerini parametre olarak gönderdik.
                    break;
                case "C": //Eğer seçim değişkeni C ise alttaki kod blogu çalışacak.
                    Console.WriteLine("Uzunluk Değerini Girin");
                    a = Convert.ToInt32(Console.ReadLine()); //Kullanıcıdan a değerini consoledan aldık.
                    Console.WriteLine("Genişlik Değerini Girin");
                    b = Convert.ToInt32(Console.ReadLine()); //Kullanıcıdan b değerini consoledan aldık.
                    Console.WriteLine(2 * a + 2 * b); //Program clasında bulunan cevrehesaplama fonksiyonu çağırdık ve fonksiyona a ve b değişkenlerini parametre olarak gönderdik.
                    break;
                case "D":
                    Console.WriteLine("Yarı Çap Değerini Girin");
                    c = Convert.ToDouble(Console.ReadLine()); //Kullanıcıdan c değerini consoledan aldık.
                    Console.WriteLine(p * (c * c) + "(Pi sayısı 3.14 Olarak Alınmıştır)");
                    break;
                case "DC":
                    Console.WriteLine("Yarı Çap Değerini Girin");
                    c = Convert.ToDouble(Console.ReadLine()); //Kullanıcıdan c değerini consoledan aldık.
                    Console.WriteLine(2 * p * c + "(Pi sayısı 3.14 Olarak Alınmıştır)");
                    break;
            }

        }
        public double hesap() // fonksiyon dışarıdan parametre (değer) almayan fonksiyon ancak dışarıya au değişkenini döndürüyor.
        {
            double au = 1.8;
            return au;
        }

        public double fiyat()// fonksiyon dışarıdan parametre(değer)almayan fonksiyon ancak dışarıya au değişkenini döndürüyor.
        {
            double grfiyati = 585;
            return grfiyati;
        }

        public double ivmehesapla(double ilkhiz,double sonhiz,double sure)
        {
            double ivme = sonhiz - ilkhiz/(sure);
            return ivme;
        }

        
    }
}
