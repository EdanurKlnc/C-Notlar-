
namespace Kalitim.Lib
{
    public class Dikdörtgen : Sekil
    {
        public double Y { get; set; }

        public override double AlanHesapla() => X * Y;

        public override double CevreHesapla()
        {
            return 2 * (X + Y);

        }
    }
}
