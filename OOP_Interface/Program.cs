// See https://aka.ms/new-console-template for more information
//interface newlenemez ama interfaceden kalıtım alan class newlenerek interface tipte bir değişkene sahip olabiliriz.
using OOP_Interface;
using System.Net.Http.Headers;
/*
IislemIsmiYazdirir[] islemler = new IislemIsmiYazdirir[] //1.yöntem
{

};

List<IislemIsmiYazdirir> islemListesi = new List<IislemIsmiYazdirir>(); //2.yöntem
*/

ToplamaIslemYoneticisi t = new ToplamaIslemYoneticisi();
CarpmaIslemYoneticisi c = new CarpmaIslemYoneticisi();

List<IislemIsmiYazdirir> islemler = new List<IislemIsmiYazdirir> { t, c };

foreach (var item in islemler)
{
    item.IslemIsmiYazdir();
}
Console.WriteLine("\n");
{ }
bool kontrol = Int32.TryParse(Console.ReadLine(), out int sectigiIslem);
if (!kontrol)
{
    Console.WriteLine("gecerli secim yap");
}
if (sectigiIslem == (int)IslemTurleri.Toplama)
{
    t.IslemSonucunuYazdir();

}
else if (sectigiIslem == (int)IslemTurleri.Carpma)
{
    c.IslemSonucunuYazdir();
}