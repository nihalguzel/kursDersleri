using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Arabalar
    {

        ~Arabalar(){
            Console.WriteLine("Araba Gitti");// Yıkıcı metod (destructor) yapıcı metoddan hemen sonra çalışır.
        }
    }
}
