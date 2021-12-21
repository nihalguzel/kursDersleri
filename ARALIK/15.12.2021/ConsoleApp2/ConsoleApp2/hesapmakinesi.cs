using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class hesapmakinesi
    {
        public double sayi1 { get; set; }
        public double sayi2 { get; set; }
        public string oprt  { get; set; }
        public string islem { get; set; }

        public hesapmakinesi(string _islem)
        {
            islem = _islem;
        }
        public hesapmakinesi(double _sayi1,double _sayi2,string _oprt) 
        {
            sayi1 = _sayi1;
            sayi2 = _sayi2;
            oprt = _oprt;
        }

        public double hesapla()
        {
            double sonuc=0;
            switch (oprt)
            {
                case "+" :
                    sonuc = sayi1 + sayi2; 
                    break;
                case "-":
                    sonuc = sayi1 - sayi2;
                    break;
                case "*":
                    sonuc = sayi1 * sayi2;
                    break;
                case "/":
                    sonuc = sayi1 / sayi2;
                    break;
            }
          
               return sonuc;
        }
    }
}
