
namespace AracTakipUygulamasi
{
    public class Arac
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string ModelYili { get; set; }
        public string SaseNo { get; set; }
        public string YakitTipi { get; set; }
        public string VitesTipi { get; set; }
        public string MotorHacmi{ get; set; }
        public byte[] Fotograf { get; set; }

        public override string ToString()
        {
            return $"{this.Marka}";
        }
    }
}
