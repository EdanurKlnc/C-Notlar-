

using System.Text.RegularExpressions;

namespace WFormGiris
{
    public class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Tel { get; set; }
        public string Tc { get; set; }
        public DateTime DogumTarihi { get; set; }

        public byte[] Fotograf { get; set; }

        public override string ToString()
        {
            return $"{this.Ad} {this.Soyad}";
        }
    }
}
