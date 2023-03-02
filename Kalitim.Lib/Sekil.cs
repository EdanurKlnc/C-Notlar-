

namespace Kalitim.Lib
{
    public abstract class Sekil //absrtact soyut nesne.
    {
        public Sekil() { }

        public Sekil(int x) //Constract metot
        {
            this.X = x ;
        }
        public double X { get; set; }
        public virtual double AlanHesapla() => X * X; //virtual tanımlı class elemanları kalıtım alıan yerlerde tanımlandığı gibi çalışır.Eğer calışma şeklini değiştirmek istiyorsak overrideie değiştireniliriz.

        // public double CevreHesapla() => 4 * X;
        public abstract double CevreHesapla();


    }
}
