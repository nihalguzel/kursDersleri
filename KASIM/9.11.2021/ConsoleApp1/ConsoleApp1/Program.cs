using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* y'ye değer ekleme y kadar x defa*/
            int x = 15;
            int y = 3;
            
            for(int i = 0; i <= x; i++)
            {
                y += y;
                Console.WriteLine(y);
            }
            /* y'ye değer ekleme y kadar x defa sonu*/
            
            /* 5 defa * değeri yazdırma*/ 
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("*");
            }
            /* 5 defa * değeri yazdırma sonu*/

            /* 4x5 lik Matris */
            for (int i = 0; i < 4; i++)
            {
               Console.WriteLine("");
                for( int t = 0; t < 5; t++)
                {
                    Console.Write("*");
                }
            }
            /* 4x5 lik Matris Sonu */

            /* Dik Üçgen Oluşturma*/

            for(int j = 1; j < 6; j++)
            {
                Console.WriteLine("");
                for( int z = 0;z < j; z++)
                {
                    Console.Write("x");
                }
            }

            /* Dik Üçgen Oluşturma Sonu*/

            /* Ters Dik Üçgen Oluşturma*/

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("");

                for(int k = 6-i; k >= 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
            }

            /* Ters Dik Üçgen Oluşturma Sonu*/


            /* Çam Ağacı Oluşturma*/

            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine("");

                for (int k = 6 - i; k >= 0; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i*2-1; j++)
                {
                    Console.Write("*");
                }
            }

            for (int l = 0; l <= 4 - 1; l++)
            {
                Console.WriteLine("");
                for (int k = 0; k <= 4; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= 2; j++)
                {
                    Console.Write("*");
                }
            }

            /* Çam Ağacı Oluşturma Sonu*/

            /*  Ters Çam Ağacı Oluşturma*/

            for (int i = 1; i < 5   ; i++)
            {
                Console.WriteLine("");

                for (int k = 0 ; k <= i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 9-2*i; j++)
                {
                    Console.Write("*");
                }
            }
            /* Ters Çam Ağacı Oluşturma Sonu*/

            string ad = "";
            string sifre = "";
            string girisad = "";
            string girissifre = "";
            int girishakki = 3;

            /*Kullanıcı Tanımlama*/
            kullanicitanimlama:
                Console.WriteLine("Adınızı Girin");
                ad = Console.ReadLine();
                Console.WriteLine("Şifrenizi Girin");
                sifre = Console.ReadLine();
            /*Kullanıcı Tanımlama Sonu*/


            /*Kullanıcı Girişi*/

            kullanicigirisi:
                Console.WriteLine("Giriş İçin Adınızı Girin");
                girisad = Console.ReadLine();
                Console.WriteLine("Giriş İçin Şifrenizi Girin");
                girissifre = Console.ReadLine();

                if (ad == girisad && sifre == girissifre)
                {
                    Console.WriteLine("Giriş Başarılı");
                }

                else
                {
                    Console.WriteLine("Giriş Başarısız "+girishakki+" hakkınız kaldı");
                girishakki = girishakki - 1;
                        if (girishakki > 0)
                        {
                            goto kullanicigirisi;
                        }
                        else {
                            Console.WriteLine("Giriş Hakkınız Doldu Kullanıcı Tanımlama Ekranına Yönlendiriliyorsunu");
                            goto kullanicitanimlama;
                        }
            }

            /*Kullanıcı Girişi Sonu*/
            

        }
    }
}
