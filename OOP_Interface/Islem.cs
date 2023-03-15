
namespace OOP_Interface
{
    internal abstract class Islem : IislemIsmiYazdirir
    {
        public IslemTurleri IslemTuru { get; set; }

        public void IslemIsmiYazdir()
        {
            //örnek; toplama için 1e bas
            Console.WriteLine( $"{IslemTuru} ----> {(byte)IslemTuru}");

        }
    }
    enum IslemTurleri : byte
    {
        Toplama,
        Cikarmai,
        Carpma
    }
}
