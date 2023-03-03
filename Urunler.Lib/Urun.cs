
namespace Urunler.Lib
{
    public abstract class Urun
    {
        private decimal _urununFiyati;
        public string urunIsmı { get; set; }
        public decimal urunFiyati
        {

            get => _urununFiyati;

            set
            {
                if (value < 0)
                {
                    throw new Exception("Fiyat sıfırdan büyk olmalı");
                }
                _urununFiyati = value;
            }
        }
        //procted  = sadece kalıtım verildiği sınıflar tarafında erişilir.
        public int Stok { get; protected set; } = 0;

        public int SatisYap(int adet)
        {
            if (this.Stok >= adet)
            {
                this.Stok -= adet;
            }
            else
            {
                throw new Exception("Stokt yeterli ürün yok");
            }
            return this.Stok;
        }
        public int StokEkle(int adet)
        {
            this.Stok += adet;
            return this.Stok;

        }

        public byte[] Fotograf { get; set; }

    }
}
