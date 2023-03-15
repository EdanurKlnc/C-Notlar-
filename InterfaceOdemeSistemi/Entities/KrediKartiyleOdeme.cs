using InterfaceOdemeSistemi.AbstractEntities;
using InterfaceOdemeSistemi.Interfaces;


namespace InterfaceOdemeSistemi.Entities
{
    internal class KrediKartiyleOdeme : Odeme, IOdemeAlabilir
    {
        public string KartNumarasi { get; set; }
        public string KartSahibi{ get; set; }
        public byte SonKullanimAy { get; set; }
        public byte SonKullanimYil { get; set; }
        public decimal OdenecekTutar { get; set; }
        public int CVC { get; set; }
        public string OdemeYap()
        {
            OdemeTarihi = DateTime.Now;
            return $"Kartınızdan ödeme alınmıştır." ;
        }
    }
}
