
namespace Kalitim.Lib
{
    public class Dikdörtgen : Sekil
    {
        public Dikdörtgen()
        { }
        public double Y { get; set; }

        public Dikdörtgen(int x, int y) : base(x)
        {
            this.Y = x;
        }
        public override double AlanHesapla() => X * Y;

        public override double CevreHesapla()
        {
            return 2 * (X + Y);

        }
    }
}
