

namespace AracTakip
{
    public class Model : BaseModel
    {
        public string Ad { get; set; }
        public KasaTipleri KasaTipleri { get; set; }
        public Marka Marka { get; set; }
        public List<Arac> Araclar { get; set; } = new List<Arac>(); //Aracın birden cok modeli var

        public override string ToString()
        {
            return Ad;
        }
    }

}
