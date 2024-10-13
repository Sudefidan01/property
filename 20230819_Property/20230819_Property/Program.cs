using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230819_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Property
            //Class yapıları içerisinde tanımlanan bazı değişkenlerin sadece okunabilir veya sadece yazılabilir olmasını isteyebiliriz
            //Tanımlanan değişkenlerin yanına {get; set;} değerleri belirtilir
            //get=>Sadece okunabilir
            //Set=>Sadece yazılabilir
            //Manasına gelir
            //Bu sayede erişilmesini istemediğimiz bir veriye uluşımı kısıtlamış oluruz
            //Property ler içerisinde get ve set alanlarına {} blok alanları oluşturup istediğiniz işlemleri yaptırabilirsiniz

            Ogrenci o = new Ogrenci();
            o.ad = "Ali";
            o.soyad = "Polat";
            o.n1 = 67;
            o.n2 = 86;
            o.ortalama = 50;

            Console.WriteLine("Adı : "+o.ad);
            Console.WriteLine("Soyad : "+o.soyad);
            Console.WriteLine("1.Not : "+o.n1);
            Console.WriteLine("2.Not : "+o.n2);
            Console.WriteLine("Ortalama : "+o.ortalama);

            Console.ReadKey();
           

        }
    }
}
