using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_23112021_43_Method_GeneralForm
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o1 = new Ogrenci();

            
            o1.ogrenciMethod2();
            o1.selamlaOgrenci();

            Ogrenci o2 = new Ogrenci();
            o2.ogrenciMethod2();
            o2.selamlaOgrenci();

            Console.ReadLine();
        }
        static void Selamla()
        {
            Console.WriteLine("Merhaba");
        }
    }
}