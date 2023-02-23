
/*        HATA YÖNETİMİ
 * Sistemsel ve Mantıksal hata olamak üzere 2 tanedir.
 * İstediğimiz satıra kadar çalıştırmak için 
 * breakpoint (kırmızı nokta) yaparak hata tespiti yapabiliriz.(Depug mod)
 */

Console.WriteLine("0 ile 10 arasında bir sayı giriniz");
int hak = 3;


do
{
    try  //Sadece hata olacak yerleri try içine yazıyoruz
    {

        int girilenSayi = Convert.ToInt32(Console.ReadLine()); //String değeri int değerine çevirme
        if (girilenSayi < 0 || girilenSayi > 10)
        {
            throw new Exception("Girilen sayı 0 ile 10 arasında olmalıdır"); //Exception = hata fırlatma
        }
        Console.WriteLine($"Girdiğiniz sayı: {girilenSayi}");
        break; //Çift tıklandığında hangi döngüyü kırdığını belirtiyor.
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        hak--;
    }
    finally //Bu blok her durumda çalışır
    {
        Console.WriteLine("İşlem tamamlandı");
    }
} while (hak > 0);
if (hak > 0)
{
    Console.WriteLine("Tebrikler");
}
else
{
    Console.WriteLine("Başarısız");
}
//2.yöntem
Console.WriteLine("Bir sayı daha giriniz");
string giris = Console.ReadLine();
if (int.TryParse(giris, out int sayi))
{
    Console.WriteLine("Girdiğiniz sayi:" + sayi);
}