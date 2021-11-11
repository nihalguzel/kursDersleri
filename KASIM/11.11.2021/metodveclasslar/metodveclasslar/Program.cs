using System;

namespace metodveclasslar
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program(); //Program classındaki metodlara erişmek için Program classından yeni birtane oluşturuldu ve prg değişkeninde atandı.

            goto ornek2blogu;

            prg.metod1(); //prg değişkeni kullanılarak Program classındaki metod1 fonksiyonuna eriştik.
            
            prg.metod2(5); //prg değişkeni kullanılarak Program classındaki metod2 fonksiyonuna eriştik ve bu metoda 5 değerini gönderdik.

            Console.WriteLine("Cinsiyetinizi Girin");
            string cinsiyet = Console.ReadLine();
            Console.WriteLine("Boy Girin");
            double boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Kilo Girin");
            double kilo = Convert.ToDouble(Console.ReadLine());

            prg.bkendeksihesapla(cinsiyet, boy, kilo); 

            Console.WriteLine(prg.hesaplamafonksiyonu());//Program clasından metodu çağırdık ve metodun return ettiği değeri ekrana yazdırdık.

            Console.WriteLine(prg.degeralanhesaplamafonksiyonu(5));//Metodumuzu çağırdık ve metodumuz int değer aldığı için burada fonksiyonu bir int değeri gönderdik int bir değişkende gönderebilirdik.

        karenincevresihesaplama:

            int uzunluk, genislik = 0;

            Console.WriteLine("Dikdörtgen Çevresini Hesaplama \n ");
            Console.WriteLine("Uzunluk Giriniz");
            uzunluk = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Genişlik Giriniz");
            genislik = Convert.ToInt32(Console.ReadLine());

            int sonucdegeri =prg.cevrehesapla(uzunluk, genislik);
            Console.WriteLine(sonucdegeri);

        ornek1blogu:

            while (true) { 
            int a, b = 0;
                Console.Clear();
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
                        prg.alanhesaplama(a, b); // Program clasında bulunan alan hesaplama fonksiyonunu çağırdık ve fonkisyona a ve b değerlerini parametre olarak gönderdik.
                        break;
                    case "C": //Eğer seçim değişkeni C ise alttaki kod blogu çalışacak.
                        prg.cevrehesaplama(a, b); //Program clasında bulunan cevrehesaplama fonksiyonu çağırdık ve fonksiyona a ve b değişkenlerini parametre olarak gönderdik.
                        break;
                }

                Console.ReadKey(); // Kullanıcının bir tuşa basmasını bekliyoruz ki işlem bittiğinde ekran direk whileın başına dönüp temizlenmesin.

            }

        ornek2blogu:
            while (true)
            {
                Console.Clear();
                double birincisayi, ikincisayi = 0;
                string secim = "";
                Console.WriteLine("<------- HESAP MAKİNESİ --------> \n");
                Console.Write("İlk Sayınızı Girin");
                birincisayi = Convert.ToDouble(Console.ReadLine());
                Console.Write("İkinci Sayınızı Girin");
                ikincisayi = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("İşleminizi Seçin Toplama(+),Çarpma(*),Çıkarma(-),Bölme(/)");
                secim = Console.ReadLine();
                
                switch (secim) {

                    case "+":
                        prg.toplamafonksiyonu(birincisayi, ikincisayi);
                        break;
                    case "*":
                        prg.carpmafonksiyonu(birincisayi, ikincisayi);
                        break;
                    case "-":
                        prg.cikarmafonksiyonu(birincisayi, ikincisayi);
                        break;
                    case "/":
                        prg.bölmefonksiyonu(birincisayi, ikincisayi);
                        break;
                }

                Console.ReadKey();
                    
            }

        }

         //Değer Almayan Değer Döndürmeyen Metod
        public void metod1() //fonksiyonun tanımlanması satırı burada fonksiyon bir değişken alacak ya da return edecek ise parantez için belirtiyoruz.
        {
            Console.WriteLine("Merhaba Metod 1"); //Bu fonksiyon çalıştırıldığında yapılması gereken işlemleri burada belirttik
        }
        //Değer Almayan Değer Döndürmeyen Metod Sonu

        //Değer Alan Değer Döndürmeyen Metod
        public void metod2(int a) //metodu tanımlarken burada metodun alması gereken a değişkenini tanımladık.
        {
            int b = 8;
            int sonuc = 0;
            sonuc = a * b; //dışarıdan gönderilen a değişkeni ile metod içinde tanımladıgımız b değişkenini çarptık.
            Console.WriteLine(sonuc); //sonuc değerini ekranda yazdırdık.
        }
        public void bkendeksihesapla(string cinsiyet,double boy,double kilo) { //fonksiyonun alacağı değerleri burada parantez içinde belirttik

            double sonuc = 0;
            switch (cinsiyet)
            {
                case"e":
                    sonuc= (kilo / (boy * boy)) * 10000;
                    break;
                case "k":
                     sonuc = ((kilo / (boy * boy)) * 0.9) * 10000;
                    break;
            }
            
            Console.WriteLine(sonuc); //fonksiyona gönderilen parametreleri islemde kullanarak sonuc değişkenini burada ekrana yazdırdık.
        }
        //Değer Alan Değer Döndürmeyen Metod Sonu

        //Değer Almayan Değer Döndüren Metod
        public int hesaplamafonksiyonu() // geri döndüreceğimiz değer tipi ne ise fonksiyonu ona göre tanımlıyoruz. Biz int değer döndüreceğimiz için fonksiyonu int olarak tanımladık.
        {
            int a = 5;
            int b = 6;
            int sonuc = a + b;

            return sonuc; // yukarıda işleme giren sonuc değişkeninini fonksiyon çağrıldığında kullanılması için return ettik.
        }
        //Değer Almayan Değer Döndüren Metod Sonu

        //Değer Alan Değer Döndüren Metod
        public int degeralanhesaplamafonksiyonu(int c)
        {
            int a = 5;
            int b = 4;
            int sonuc = a + b + c;
            return sonuc;
        }
        //Değer Alan Değer Döndüren Metod Sonu

        //Çevre Hesaplama Fonksiyonu
        public int cevrehesapla(int uzunluk,int genislik)
        {
            int sonuc = 2 * uzunluk + 2 * genislik;

            return sonuc;

        }
        //Çevre Hesaplama Fonksiyonu Sonu

        //Örnek 1 Çalışması Alan Çevre Hesaplama
            
        public void cevrehesaplama(int genislik,int uzunluk) // cevrehesaplama fonksiyonu oluşturduk ve iki adet int tipinde parametre alacagını burada belirttik.
        {
            int sonuc = 0;

            sonuc = 2 * (uzunluk + genislik);

            Console.WriteLine("Hesaplanan Cevre :" + sonuc); // cevrehesaplama fonksiyonu değer döndüren bir fonksiyon olmadığı için hesaplanan sonucu burada ekrana bastırdık.
        }

        public void alanhesaplama(int genislik, int uzunluk) // alanhesaplama fonksiyonu oluşturduk ve iki adet int tipinde parametre alacagını burada belirttik.
        {
            int sonuc = 0;

            sonuc = (uzunluk * genislik); // alanesaplama fonksiyonu değer döndüren bir fonksiyon olmadığı için hesaplanan sonucu burada ekrana bastırdık.

            Console.WriteLine("Hesaplanan Alan :" + sonuc);
        }

        //Örnek 1 Çalışması Sonu Alan Çevre Hesaplama Sonu

        //Örnek2 Çalışması Hesap Makinesi
        public void toplamafonksiyonu(double a, double b)
        {
            double sonuc = 0;
            sonuc = a + b;
            Console.WriteLine(sonuc);
        }
        public void cikarmafonksiyonu(double a, double b)
        {
            double sonuc = 0;
            sonuc = a - b;
            Console.WriteLine(sonuc);
        }
        public void carpmafonksiyonu(double a, double b)
        {
            double sonuc = 0;
            sonuc = a * b;
            Console.WriteLine(sonuc);
        }
        public void bölmefonksiyonu(double a, double b)
        {
            double sonuc = 0;
            sonuc = a / b;
            Console.WriteLine(sonuc);
        }
        //Örnek2 Çalışması Hesap Makinesi Sonu


    }
}
