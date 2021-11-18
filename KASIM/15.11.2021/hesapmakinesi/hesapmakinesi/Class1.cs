using System;
using System.Collections.Generic;
using System.Text;

namespace hesapmakinesi
{
    class Class1
    {
        public static string sayi1 ="";
        public static string sayi2 ="";
        public static double sonuc = 0;
        public static string oprt;
        public static string metin;
        public static string strsayi="";


        public void hesapmakinesi(){


            ConsoleKeyInfo deger = default(ConsoleKeyInfo);

            do
            {
                deger = Console.ReadKey(true);
                if (deger.KeyChar == '-' || deger.KeyChar == '+' || deger.KeyChar == '/' || deger.KeyChar == '*') {

                    oprt = deger.Key.ToString();
                    switch (oprt)
                    {
                        case "+":
                            sonuc = Convert.ToDouble(sayi1) + Convert.ToDouble(sayi2);
                            sonuc += Convert.ToDouble(sayi2);
                            break;
                    }

                    sayi2 += deger.KeyChar.ToString();
                }
                else
                {

                    sayi1 += deger.KeyChar.ToString();
                    Console.Clear();
                    Console.WriteLine(sayi1);

                }
            }
            while (!(deger.Key==ConsoleKey.Enter));
        }
    
    }
}
