using System;

namespace ilkders
{
    class Program
    {
        static void Main(string[] args)
        {
            goto baklavadeseni;

            // Tek satırlık yorum için kullanılır.

            /*
             * Çok Satırlı Yorumlarda Yarum satırı bu şekilde kullanılır 
             * Satır 1 yorum
             * Satır 2 yorum
             * 
             */

            //Değişken Tanımlama Örnekleri
            
                //Değişkenler tanımlanırken sırası ile (Değişken Tipi)(Değişken Adı)=atanacak değer var ise yazılır yok ise boş geçilir.

                int tamsayi = 10;
            
                int sayi;//Bu satırda sayi değşkeni boş bırakılarak bir sonraki satırda içine değer atandı
                sayi = 6;

                int sayi1, sayi2; //Çoklu tanımlamalar boş olarak bu şekilde tanımlanabilir.
                int s1 = 5, s2 = 5; //Çoklu tanımlamalarda değer atanacak ise bu şekilde kullanılabilir.

                byte  b1 =255; //byte tipi 0 ile 255 arasında değer alır
                sbyte b2=127; //sbyte tipi -128 ile + 128 arasında değer alır

                short sh1 =32767; //short tipi -32.768 ile +32.678 arasında değer alır

                int s3 = 1234; //int tipi -2.147.448.364 ile -2.147.448.364 arasında değer alır

                float f1 = 15.5f; //float tipi kullanılırken atanan değer yanına f harfi eklenmek zorundadır.
                double d1 = 15.5; // double tipide ondalıklı sayılarda kullanılır float değeri ile aynı değerlerde kullanılır ancak sonunda f kullanma zorunluluğu yoktur.


                string değer = ""; // metin değerleri için kullanılır String tipi değerler atanırken "" tırnak içine değer girilir.
                char k1 = 'k';     // char tipi yalnızca tek karakter alır.

                bool varyok = true; // booltipi yalnızca true ve false değerleri alır

                object o1 = 5;    //objectler değer tanımlama tipine göre kendi tipini belirler bu bir int objesidir.
                object d3 = 12.5; //objectler değer tanımlama tipine göre kendi tipini belirler bu bir double objesidir.
                                  //Değişken Tanımlama Örnekleri Sonu

            /* Aritmetik Operatörler
               
            + Sayısal işlemlerde toplama string değerlerde yan yana yazma işlevine yarar,
            - Çıkartma
            * Çarpma
            / Bölme
            % Mod Alma
            = Değer Atama
            ! Durumun Değili (bool değişkeninde kullanılır.)
            
            Aritmetik Operatörler Sonu */

            /* Karşılaştırma Operatörleri

           == Eşitlik
            < Küçüktür
            > Büyüktür
            <= Küçük Eşittir
            >= Büyük Eşittir
            != Eşit Değil

           Karşılaştırma Operatörleri Sonu */

            /* Mantıksa Operatörleri

             && (ve)(and) birden fazla koşulun gerçekleşmesi durumunda
             || (veya)(or) bir koşulun gerçekleşmesi durumunda

           Mantıksal Operatörleri Sonu */


            //Değişken Tanımlama Örnekleri Sonu

            Console.Write("Hello"); /*Yeni bir satır oluşturmaz yazılan değeri tekbir satırda gösterir*/

            Console.WriteLine("Hello World!"); /*Strin değer ekrana yazıldıktan sonra bir alt satıra geçer*/

            Console.WriteLine("Hello \nWorld!"); /*String arasına yazılan \n komutu yeni bir satır eklemeye yarar*/

            //Aritmetik Operatörleri Kullanımı


                    int i = 5, j = 6, sonuc;
                    sonuc = i + j;

                    double dsonuc;
                    dsonuc = Convert.ToDouble(j) /Convert.ToDouble(i); //bölme işlemlerinde int değişken tipini kabul etmez bu nedenle double tipi kullanılmalı.

                    Console.WriteLine(sonuc);       //sonuc değeri ekrana yazdırılır çıktı 11
                    Console.WriteLine(sonuc+9);     //int değer ile int değer toplanabilir çıktı 20
                    Console.WriteLine(sonuc+9.5);   //int değer ile double değer toplanabilir çıktı 20.5
                    Console.WriteLine(sonuc + "9.5");//toplamın yanına string olarak 9.5 yazar çıktı 119.5

                    Console.WriteLine(dsonuc);
                        //Konsoldan veri alarak işlem yapma

                        Console.WriteLine("1.Sayı Gir");
                        int a = Convert.ToInt32(Console.ReadLine());//Console uygulamaları string olarak değer alıp gönderdiği için consoledan alınan girdiler sayısal değerler için Convert edilmelidir.
                        Console.WriteLine("2.Sayı Gir");
                        int b = Convert.ToInt32(Console.ReadLine());//Console uygulamaları string olarak değer alıp gönderdiği için consoledan alınan girdiler sayısal değerler için Convert edilmelidir.
                        Console.WriteLine("2.Sayı Gir");
                        int sonuc1 = a + b;

                        Console.WriteLine("İşlem Sonucu=" + sonuc1);

            //Konsoldan veri alarak işlem yapma sonu

            bool durum = true; 
            Console.WriteLine(!durum); // önüne koyulan ! işareti durum değişkenini tersine çevirir çıktı false
            double sayi3, sayi4, sonuc2;
            Console.Write("Sayi 1 giriniz: ");
            sayi3 = Convert.ToDouble(Console.ReadLine());// sayıyı console'dan alınıp double'a convert edildi.
            Console.Write("Sayi 2 giriniz: ");
            sayi4 = Convert.ToDouble(Console.ReadLine());// sayıyı console'dan alınıp double'a convert edildi.
            sonuc2 = sayi3 % sayi4; //sayi3 ün sayi4 e bölümünden kalan sonuc2 ddeğişkenine atanıyor
            double sonuc3 = (sayi3 - sonuc2) / sayi4;
            Console.WriteLine("Kalan: " + sonuc);
            Console.WriteLine("Kaçtane sayı var: " + sonuc2);

            //Aritmetik Operatörleri Kullanımı Sonu

            //Dizi Kullanımları

            int[] sayilar = { 15, 2, 65 };// int tipinde bir dizi oluşturarak içeriğini girdik.

            int[] sayilar2 = new int[5];//Dışarıdan kaç eleman sayısı gireceğimzi belittik.

            sayilar2[0] = 13; //sayilar2 dizisinin ilk elemanını atandı
            sayilar2[1] = 5;  //sayilar2 disininin ikinci elemanı atandı
            sayilar2[3] = 16; //sayilar2 dizisinin üçüncü elemanı atandı


            Console.WriteLine(sayilar2[4]); //sayilar2 dizisinin 4.elemanı yazdırıldı ancak 4 eleman atanmadığı için çıktı olarak ekranda 0 değerinin verir.

                    //Consoledan Dizi Boyutunu Alma
                    int[] sayilardizisi; //boş bir int tipinde dizi olarak sayilardizisi değişkeni tanımlandı
                    Console.Write("Dizi Kaç Elemanlı Olsun");
                    int deger = Convert.ToInt32(Console.ReadLine());//Dizinin kaç elemanlı olması gerektiğini consoledan alındı
                    sayilardizisi = new int[deger];//sayilardizisi dizisinin eleman sayısı consoledan alınan değer olarak atandı
                    
                    for(int q = 0; q < deger; q++) //0 dan girilen değere kadar bir for döngüsü oluşturduk ve for içerisinde dizinin elemanlarını tek tek console dan aldık
                    {
                        Console.Write(q + "ıncı elemeanı gir:");
                        int girileneleman = Convert.ToInt32(Console.ReadLine()); //kullanıcının girdiği değer girilen eleman değişkenine atandı
                        sayilardizisi[q] = girileneleman; //sayılar dizisinin q ıncı elemanı yani döngüden gelen değer arttıkca bu değerde artacak girilen sayı diziye eklendi

                    }

                    for(int e = 0; e < deger; e++) //0 dan dizi boyutuna kadar bir döngü oluşturduk
                   {

                        Console.WriteLine(e+"inci sayı"+sayilardizisi[e]); // dizi içindeki tüm elemanları sırası ile ekrana yazdırdık

                    }

            //Consoledan Dizi Boyutunu Alma Sonu

            //String-Bool Array Tanımlama

            string[] isimler = { "Elif", "Fatma", "Mehmet", "Ahmet" }; //isimler adında string dizi oluşturarak içini doldurduk

            string[] isimler2 = new string[5];//5 eleman sayılı bir string dizi oluşturduk

            isimler2[0] = "Ali";//isimler 2 dizisinin 0'incı elemanına Ali değerini ekledik

            bool[] booldizisi = { true, false, false, true }; //bool tipinde bir dizi oluşturduk ve içeriğini bool tipinde değerler ile doldurduk

            //String-Bool Array Tanımlama Sonu
            //Dizi Kullanımları Sonu

            //Karar Yapıları Kullanımı

            int r = 5;
            int t = 6;

            if (r == 5) { //if içinde r değerinin 5 olup olmadıgını kontrol ettirdik ve 5 ise aşağıdaki değeri yazdırmasını istedik
                Console.WriteLine("Şart Sağlandı Değer 5");
            }
            else //if de eklenen koşul sağlanmadı ise yani değer 5 değil ise aşağıdaki değeri yazmasını istedik
            {
                Console.WriteLine("Şart Sağlanmadı Değer 5 değil");
            }

            if (r == 5 && t == 6){ //aşağıdaki kod bloğunun çalışması için r nin 5 ve t nin 6 olması gerekmekte yani iki koşulda sağlanmalı

                Console.WriteLine("İki Şartta Saglandı r değeri 5 t değeri 6");
            }

            else // iki koşulda sağlanmazsa ise aşağıdaki kod bloğunun çalışmasını istedik
            {
                Console.WriteLine("İki şarttan herhangi biri sağlanmadı");
            }

            string deger1 = Console.ReadLine(); //değer 1 olarak kullanıcıdan girdi aldık

            switch (deger1) { //değer1 icerigini kontrol ediyoruz ve deger1 in içerisindeki sonuçlara göre aşağıdaki durumları oluşturuyoruz.
                case "Onur"://eğer değer1 içeriği Onur ise aşağıdaki kodun çalışmasını istiyoruz
                    Console.WriteLine("Hoşgeldin Onur");
                    break;
                case "Ayşen"://eğer değer1 içeriği Ayşen ise aşağıdaki kodun çalışmasını istiyoruz
                    Console.WriteLine("Ayşen Hoşgeldin");
                    break;
                default: //Eğer yukarıdaki durumlardan hiç birisi karşılanmıyor ise default olarak aşağıdaki kodun çalışmasını istiyoruz.
                    Console.WriteLine(deger1+"Sen Yinemi Geldin");
                    break;

            }
            //Karar Yapıları Kullanımı Sonu

            //Hesap Makinesi Yapımı
            double girilensayi1, girilensayi2, islemsonucu;
            string islem = "";

            islembaslangici:
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
                    Console.WriteLine("Topalama Sonucu:"+islemsonucu);
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
            goto islembaslangici;

            //Hesap Makinesi Yapımı Sonu

            //Boy Kilo Endeksi Hesaplama

            boykiloendeksi:

            string cinsiyet = "";
            double boy;
            double kilo;
            double hesaplamasonucu=0;

            cinsiyetgirisi:
            Console.WriteLine("Lütfen Öncelikle Cinsiyetinizi Giriniz Erkek için E Kadın İçin K ");
            cinsiyet=Console.ReadLine();
            Console.WriteLine(cinsiyet);

            if(cinsiyet == "E")
            {
                
                goto boygirisi;
            }

            else if(cinsiyet == "K")
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
                    hesaplamasonucu = (kilo / (boy * boy))*10000;
                    break;

                case "K":
                    hesaplamasonucu = ((kilo / (boy * boy)) * 0.9)*10000;
                    break;

            }


            if (hesaplamasonucu < 18.5)
            {
                Console.WriteLine("Hesaplanan Vücut Kitle Endeksiniz="+hesaplamasonucu);
                Console.WriteLine("Bu Sonuca Göre Zayıfsınız");
            }

            else if (hesaplamasonucu >= 18.5 && hesaplamasonucu<24.9)
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
            //Boy Kilo Endeksi Hesaplama Sonu

            //Döngü Kullanımları

            for(int i1 = 0 ; i1 < 5; i1 ++) //for içinde indeks belirtmek için i1 değişkenini tanımladık ve i1 0 dan 5 e kadar aşağıdaki kod bloğu tekrar tekrar çalışacak. ve her çalıştığınd i1 değikeni 1 artacak
            {
                Console.WriteLine(i1); //i1 değişkenini ekrana yazdırdık ekran çıktısı 0,1,2,3,4 olacaktır.
            }

            string[] isimlerdizisi = {"Nihal","Duygu","Onur","Arif"};

            for(int i2 = 0; i2 < isimlerdizisi.Length; i2++) // i2 değişkeninin bitiş değeri dinamik olarak isimlerdizisi arrayinin boyutu kadar for döngüsü çalışacak.
            {
                Console.WriteLine(isimlerdizisi[i2]);//isimlerdizisini sırası ile ekrana yazdırdık
            }

            baklavadeseni:

            for(int i3=1;i3<=4;i3++){

                Console.WriteLine("");

                for(int i4 = 0; i4 <= 4 - i3; i4++)
                {
                    Console.Write(" ");
                }

                for (int i5 = 1; i5 <= i3*2-1; i5++)
                {
                    Console.Write("*");
                }
            }

            for (int i3 = 1; i3 <= 3; i3++)
            {

                Console.WriteLine("");

                for (int i4 = 0; i4 <= i3; i4++)
                {
                    Console.Write(" ");
                }

                for (int i5 = 1; i5 <= 7-2*i3; i5++)
                {
                    Console.Write("*");
                }
            }

            int i6 = 0;

            while (i6 < 5) //while içerisindeki şart sağlanana kadar altta bulunan kod bloğu çalışır.
            {
                i6 += 1;
                Console.WriteLine(" \n Hello World !");

            }

            int i7 = 0;

            while (true) //while içerisindeki değer true iken altta bulunan kod bloğu çalışır.
            {
                i7 += 1;
                Console.WriteLine(" \n Hello World !");

                if (i7 == 5)
                {
                    break; //i7 değişkeni 5 değerine ulaştığında while döngüsü kırılarak döngüden çıkılıyor.
                }

            }

            //Döngü Kullanımları Sonu

        }
    }
}
