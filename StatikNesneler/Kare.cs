
namespace StatikNesneler
{
    // bir nesnenin içerisinde static nesne tanımlayabilmek için sınıfın statik tanımlanmasına gerek yoktur. Statik tanımlanan sınıflarda tüm sınıf elemanları statik tanımlanalıdır.
    //Kalıtım yapamazlar

    public abstract class Sekil
    {
        public double X { get; set; }
        public abstract double AlanHesapla();

    }
    public class Kare : Sekil
    {
        public override double AlanHesapla() => X * X;
       // public static double AlanHesapla(double x) => X * X;

    }
    public class Dikdortgen : Sekil
    {
        public double Y { get; set; }
        public override double AlanHesapla() => X * Y;

    }
    //Statik sınıftan instance alımaz.
    public static class Geometri
    {
        public static double X { get; set; }
        public static double AlanHesapla(double x) => X * X;
    }
}
