using InterfaceOrnek.AbstractEntities;
using InterfaceOrnek.Interface;

namespace InterfaceOrnek.Entities
{
    internal class Kare : Sekil, IAlanaSahiptir, ICevreyeSahiptir, IKosegeneSahiptir
    {
        #region Properties
        public int Kenar { get; set; }

        #endregion
        public double AlanHesapla()
        {
            try
            {
                return Math.Pow(Kenar, 2);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public double CevreHesapla()
        {
            try
            {
                return 4 * Kenar;
            }
            catch (Exception)
            {

                throw;
            }        }

        public double KosegenHesapla()
        {
            return 0;
        }
    }
}
