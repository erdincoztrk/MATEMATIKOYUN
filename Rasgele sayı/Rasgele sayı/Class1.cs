using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rasgele_sayı
{
    class Class1
    {
        public int tpl (int s1, int s2)
        {
            Random sayi1 = new Random();
            Random sayi2 = new Random();

            s1 = sayi1.Next(25);
            s2 = sayi2.Next(50);

            int toplam = s1 + s2;
            return toplam;
        }


    }
}
