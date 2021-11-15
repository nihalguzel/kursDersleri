using System;
using System.Collections.Generic;
using System.Text;

namespace classtanimlamalariuygulama
{
    class Class1
    {
        public int toplama(int sayi1,int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 + sayi2;
            return sonuc;
        }

        public int cikarma(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 - sayi2;
            return sonuc;
        }

        public int carpma(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 * sayi2;
            return sonuc;
        }

        public int bolme(int sayi1, int sayi2)
        {
            int sonuc = 0;
            sonuc = sayi1 / sayi2;
            return sonuc;
        }
    }
}

