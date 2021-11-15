using System;

namespace classtanimlamalari
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prg = new Program();
            prg.method();//Program Clasından Metoda ulaştık
            prg.sayi();//Program Clasından Metoda Ulaştık
            prg.metod2();//Private ancak bu classta olduğu için çağırabildik dışarıdaki classlardan cagrılamaz.
            prg.sayi2();//Private ancak bu classta olduğu için çağırabildik dışarıdaki classlardan cagrılamaz.
            metod3();//static olarak tanımladıgımız için class ile birlikte çağırmaya gerek yok.

            deneme denemeclassı = new deneme();
            denemeclassı.metod4();//deneme classı içinde public bir metod oluşturdugumuz için Program classı içinde deneme classı ile birlikte çağırdik.
        }

        public void method()
        {
            //Değer Almayan Değer Döndürmeyen method
        }

        public int sayi()
        {
            //Değer Almayan Değer Döndüren Method
            int sonuc = 0;
            return sonuc;
        }
        private void metod2() // metod private olarak tanımlandığı için bu class içinde çağrılabilir ancak başka bir classtan çağrılamaz.
        {

        }

        public int sayi2()// metod private olarak tanımlandığı için bu class içinde çağrılabilir ancak başka bir classtan çağrılamaz.
        {
            //Değer Almayan Değer Döndüren Method
            int sonuc = 0;
            return sonuc;
        }

        public static void metod3()
        {
            //static olarak tanımlandığı için bu classa ait oldugunu belirtmiş oluyoruz ve çağırırken classı tekrar çağırmaya ihtiyacımız yok.
        }
    }

    class deneme
    {

        public int a; // değişkeni public olarak tanımladıgımız için diğer classlardan çağırabiliriz ancak diğer classlarda değiştirerek bu classa geri gönderemeyiz.
        private int b;// değişkeni private olarak tanımladıgımız için diğer classlardan çağıramayız yalnızca bu class içinde kullanabiliriz
     
        public void metod4()
        {
            deneme dnm = new deneme();

            dnm.metod5(); // normalde bu metodlar dısarıdan cagrılamıyordu ancak metod4 ün içine alarak dışarıdan kullanımını sağlayabiliriz.
            metod6();// normalde bu metodlar dısarıdan cagrılamıyordu ancak metod4 ün içine alarak dışarıdan kullanımını sağlayabiliriz.

            //deneme classında tanımlanan metodu program classında çağıracağız.
        }

        private void metod5()
        {
            //metodu private olarak tanımladıgımız için farklı bir classtan bu metode erişemiyoruz.
        }

        public static void metod6()
        {
            //bu metodu public olarak tanımlamamıza ragmen diger classlardan cagıramıyoruz çünkü static terimi bu metodu
            //deneme classına ait bir metod yapıyor.
            //ancak static olarak tanımladıgımız için deneme classı içinde class adını kullanmadan çağırabiliyoruz.
        }
    }
}
