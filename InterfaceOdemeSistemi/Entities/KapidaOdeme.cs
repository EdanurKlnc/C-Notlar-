using InterfaceOdemeSistemi.AbstractEntities;
using InterfaceOdemeSistemi.Interfaces;

namespace InterfaceOdemeSistemi.Entities
{
    internal class KapidaOdeme : Odeme, IOdemeAlabilir
    {
        public bool PostMakinesiIstiyorMu { get; set; }
        public string OdemeAlanPersonel { get; set; } = "Edanur ";
        public bool NakitMi { get; set; }
        public decimal NakitOdenenTutar { get; set; }
        public bool KrediKartiMi { get; set; }
        public bool AcikAdres { get; set; }
        public decimal KrediKartiylaOdenenTutar { get; set; }
        public string OdemeYap()
        {
            return $"Kapıda ödemeniz {OdemeAlanPersonel} personel ile {OdemeTarihi.ToString("dd.MMM.yyyy")} tarihinde yapılacaktır.";
        }
    }
}
