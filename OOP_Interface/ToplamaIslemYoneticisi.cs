
namespace OOP_Interface
{
    internal class ToplamaIslemYoneticisi : Islem, IislemYap
    {
        public ToplamaIslemYoneticisi() //özel metot (constructor)
        {
            IslemTuru = IslemTurleri.Toplama;

        }

        public void IslemSonucunuYazdir() //interface'i implement ettik
        {
            Console.WriteLine("1.sayyi gir :");
            int s1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("2.sayyi gir :");
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( $"SONUÇ : {s1+s2}");
        }
    }
}
