using System;

namespace ilkders
{
    class Program
    {
        static void Main(string[] args)
        {

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

                        Console.WriteLine("İşlem Sonucu="+sonuc1);
                        
                        //Konsoldan veri alarak işlem yapma sonu

            //Aritmetik Operatörleri Kullanımı Sonu


        }
    }
}
