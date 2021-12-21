using System;
using System.Diagnostics;

namespace ConsoleApp2
{
    class deneme
    {
        public deneme(string ad)
        {
            Console.WriteLine(ad); // baska bir classtan bu classa tek string parametre gonderilirse bu constructor çalışır
        }
        public deneme(int yas)
        {
            Console.WriteLine(yas); // baska bir classtan bu classa tek int parametre gonderilirse bu constructor çalışır
        }
        public deneme(string ad ,int yas)
        {
            Console.WriteLine(ad+" "+yas);// baska bir classtan bu classa string ve int olarak iki parametre gonderilirse bu constructor çalışır
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //hesapmakinesi hsp;
            //double deger1 = Convert.ToInt32(Console.ReadLine());
            //string oprt=Console.ReadLine();
            //double deger2 = Convert.ToInt32(Console.ReadLine());
            //hsp = new hesapmakinesi(deger1,deger2,oprt);
            //Console.WriteLine(hsp.hesapla());

            varis vr = new varis();
            Console.WriteLine(vr.ad);
            vr.araba();
            vr.ev();

        }
    }
}
