using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230819_Property
{
    internal class Ogrenci
    {
        public string ad { get; set; }
        public string soyad;
        public int n1, n2;

        public double ortalama
        {
            get
            {
                return (double)(n1 + n2) / 2;
            }
           
        }
    }
}
