
namespace Kalitim.Lib
{
    // DikUcgen sınıfından alıtım vermek istemediğimiz için sealde keywordu ekledik
    public sealed class DikUcgen : Dikdörtgen
    {
        public DikUcgen() { }
        public DikUcgen(int x, int y) : base(x, y)
        {
            this.Y = Y;
        }
        public override double AlanHesapla()
        {   //this => bulunduğu sııftakini kullanır
            //base => kalıtım aldığı sınıfaki fonksiyonu kullanılır
            return base.AlanHesapla() / 2;
        }
        public override double CevreHesapla()
        {
            return (X + Y) + Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }
    }
}
