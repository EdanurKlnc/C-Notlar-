using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Interface
{
    internal class CarpmaIslemYoneticisi :Islem, IislemYap //1 tane class kalıtım alınabilir. Onuda interfacenin önüne yazmamız gerekiyor
    {
        public CarpmaIslemYoneticisi()
        {
            IslemTuru = IslemTurleri.Carpma;
        }

        public void IslemSonucunuYazdir()
        {
            Console.WriteLine("30 ile 20'yi carp sonuc :"+600);
        }
    }
}
