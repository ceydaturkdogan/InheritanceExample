using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public abstract class BaseKisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public void DisplayInfo()

        {
            Console.WriteLine($"Ad: {Ad}\nSoyad:{Soyad}");

        }


    }

    public class Ogrenci : BaseKisi

    {

        public string OgrenciNo { get; set; }


        public Ogrenci(string ad, string soyad)

        {
            Ad = ad;
            Soyad = soyad;
        }

        public void DisplayNumber(string ogrenciNo)
        {
            OgrenciNo = ogrenciNo;
            DisplayInfo();
            Console.WriteLine(ogrenciNo);

        }
    }

    public class Ogretmen : BaseKisi
    {


        public Ogretmen(string ad, string soyad)

        {
            Ad = ad;
            Soyad = soyad;

        }
        private int Salary { get; set; }
        public void DisplaySalary(int salary)
        {
            Salary = salary;
            DisplayInfo();
            Console.WriteLine($"Maas:{salary}");

        }
    }
}
