using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_23112021_43_Method_GeneralForm
{
    public class Ogrenci
    {
        //Method oluşturma:
        //(public,private, protected)+(void,string,int)+(method adı(parametreler)){yazılacak kodlar }
        public void selamlaOgrenci()
        {
            Console.WriteLine("Merhaba Öğrenci");
            
        }
        private void ogrenciMethod1(string ogrenciAdi,string ogrenciSoyadi)
        {
            Console.WriteLine("Öğrenci bilgileri: {0} {1}",ogrenciAdi,ogrenciSoyadi);
        }
        public void ogrenciMethod2()
        {
            ogrenciMethod1("Serdar", "Karakurt");
        }
        public string adGetir()
        {
            return " ";
        }
    }
}
