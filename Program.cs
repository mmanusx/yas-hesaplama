using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inceleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merhaba");

            Console.Write("İsminiz Nedir? ");
            string isim = Console.ReadLine();

            Console.Write("Soyisminiz Nedir?");
            string soyisim = Console.ReadLine();

            Console.Write("Yaşadığınız Şehir");
            string sehir = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("İsim: " + isim);
            Console.WriteLine("Soyisim: " + soyisim);
            Console.WriteLine("Şehir: " + sehir);

            Console.ReadLine();


        }
    }
}
