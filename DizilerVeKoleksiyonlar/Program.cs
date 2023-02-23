/*   DİZİ
 * Aynı tipteki değişkenleri ya da verileri bir arada tutabildiğimiz bir yapıdır.
 * [] ile ifade edilir
 * Boyutunu belirtmek zorundayız
 */

//Dizi tanımlama (Tek boyutlu)
using System.Collections;

int[] sayilarDizisi = new int[5]; //hangi type yazacağını bilmediğinde var kullanılır

int[] sayilar2 = new[] { 1, 2, 3, 4, 5 };

string[] kelimeler1 = new[] { "istanbul", "ankara" };

//Diziyi ekrana yazdırma
for (int i = 0; i < sayilar2.Length; i++)
{
    Console.WriteLine(sayilar2[i]);
}

string cumle = " Aynı tipteki değişkenleri ya da verileri bir arada tutabildiğimiz bir yapıdır.";
string[] kelimeler = cumle.Split(' '); //Kelimeleri bir alt sıraya gecerek alt alta yazar.
foreach (var kelime in kelimeler)
{
    Console.WriteLine(kelime);
}

//Diziye eleman ekleme
int[] sayilar = new int[5];

sayilar[0] = 5;
sayilar[1] = 4;
sayilar[2] = 3;
sayilar[3] = 2;
sayilar[4] = 1;

Random rnd = new Random(); //Random sayı atama
for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[1] = rnd.Next(1, 100); //1 dahil 100 hariç
}
Console.WriteLine(sayilar[rnd.Next(sayilar.Length)]);


//////////////Örnek/////////////
int[] secim = new int[6];

for (int i = 0; i < secim.Length; i++)
{
    int sayi = rnd.Next(1, 7);
    int index = Array.IndexOf(secim, sayi); //IndexOf = Diziye bakacak aynı sayı var ise indexini döndürecek yoksa 1 döndürür
    if (index == 1)
    {
        secim[i] = sayi;

    }
    else
    {
        i--;
    }
    /*
     * if(secimler.Contains(sayi))
     * i--;
     * else
     * secimler[i]=sayi; */

}
Console.WriteLine();

ArrayList liste = new ArrayList(); //Boyutu yok. Ekle sil yapılabilir.Obje ister. Type göre değil 
liste.Add(1); 

List<int> sayilar3 = new List<int>(); //Verdiğimiz type göre istemde bulunur.
sayilar3.Add(1);

sayilar3.Where(x => x > 18 && x < 25).ToList(); //Sorgulayıp dizide tutma






