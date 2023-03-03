//SOYUT SINIF

namespace RentACar.Lib
{
    public abstract class Tasit
    {
        public string Model { get; set; }
        public double Fiyat { get; set; }
        public int Km { get; set; }
        public string Renk { get; set; }
        public int TekerlekSayisi { get; set; }
        public int KoltukSayisi { get; set; }
        public int Stok { get; protected set; } = 0;

        public int KiralamaYap(int adet)
        {
            if (this.Stok >= adet)
                this.Stok -= adet;
            else
                throw new Exception("Kiralanacak boşta arac yok");
            return this.Stok;
        }
        public int Kirala(int adet)
        {
            this.Stok += adet;
            return this.Stok;
        }
    }

}

