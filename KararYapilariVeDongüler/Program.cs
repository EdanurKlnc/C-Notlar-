/* KARAR YAPILARI
 ***********************************
 
  if (kosul)
{
    işlemler
}
else if (koşul)
{
    işlemler
}
else
{
    işlemler
}
*************************
 Ternary-if
string sonuc = sayi2 % 2 = 0 ? "Cift" : "Tek"

*************************

swicth(değişken)
{
 case deger1: işlemler
              break; 
case deger2: işlemler
              break; 
case deger3: işlemler
              break;
}
************************************************
       DÖNGÜLER
 while (koşul)
{
    işlemler
}
***********************
 do
{
    işlemler
} while (koşul);
***********************

  for(int i=0; i<10 ; i++)
{
   işlemler
}
***********************
 foreach(var item in collection)
{
   işlemler
}
*/

Random rnd;
if (rnd == null)
    rnd = new Random();

rnd = rnd ?? new Random();
rnd ??= new Random(); //kısa kullanımı



