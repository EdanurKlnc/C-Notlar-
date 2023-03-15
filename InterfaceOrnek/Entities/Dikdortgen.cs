using InterfaceOrnek.AbstractEntities;
using InterfaceOrnek.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceOrnek.Entities
{
    internal class Dikdortgen : Sekil, IAlanaSahiptir, ICevreyeSahiptir, IKosegeneSahiptir
    {
        #region Properties
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }

        public double AlanHesapla()
        {
            return UzunKenar * KisaKenar;
        }

        public double CevreHesapla()
        {
            return (UzunKenar + KisaKenar) * 2;
        }

        public double KosegenHesapla()
        {
            return 0;
        }

        #endregion
    }
}
