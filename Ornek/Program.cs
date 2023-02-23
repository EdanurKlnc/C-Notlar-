/*
for(int i=9; i<18; i++)
{
    Console.WriteLine(i);

    if (i == 12)
    {
        i++;
    }
  
}
for(int i= 0; i<46; i=i + 15)
{
    Console.WriteLine(i);

}
*/
//1.AŞAMA
for (int saat = 9; saat < 18; saat++)
{
    Console.WriteLine($"{saat:00}:00 - { saat:00}:15");
}

//2.AŞAMA
for (int saat = 9; saat < 18; saat++)
{
    for (int dakika = 0; dakika < 46; dakika += 15)
    {
        int sonrakiSaat = saat;
        int sonrakiDakika = dakika + 15;
        if (sonrakiDakika == 60)
        {
            sonrakiDakika = 0;
            sonrakiSaat++;
        }
        Console.WriteLine($"{saat:00}:{dakika:00} - {sonrakiSaat:00}:{sonrakiDakika + 15:00}");


    }
}

//3.AŞAMA
for (int saat = 9; saat < 18; saat++)
{
    if (saat == 12)
    {
        continue;
    }
    for (int dakika = 0; dakika < 46; dakika += 15)
    {
        int sonrakiSaat = saat;
        int sonrakiDakika = dakika + 15;
        if (sonrakiDakika == 60)
        {
            sonrakiDakika = 0;
            sonrakiSaat++;
        }
        Console.WriteLine($"{saat:00}:{dakika:00} - {sonrakiSaat:00}:{sonrakiDakika:00}");


    }
}
//2.YÖNTEM
Console.ForegroundColor = ConsoleColor.DarkBlue;
DateTime baslangic = new DateTime(2000, 1, 1, 9, 0, 0);
while (baslangic.Hour < 17)
{
    DateTime birinci = baslangic;
    DateTime ikinci = baslangic.AddMinutes(15);

    Console.WriteLine($"{baslangic:HH:mm} - {ikinci:HH:mm}");
    baslangic = baslangic.AddMinutes(15);
    if (baslangic.Hour == 12)
    {
        baslangic = baslangic.AddHours(1);
    }
}

//3.YÖNTEM
Console.ForegroundColor = ConsoleColor.DarkYellow;

//For içinde oluşturulan değişken {} dışında kullanılamaz. Değişkeni dışarda tanımlamalıyız
//(Değişken for içinde)---> for (DateTime baslangic2 = new DateTime(2000, 1, 1, 9, 0, 0); baslangic2.Hour < 17; baslangic2 = baslangic2.AddMinutes(15)) 

DateTime baslangic2 = new DateTime(2000, 1, 1, 9, 0, 0);
    for (; baslangic2.Hour < 17; baslangic2 = baslangic2.AddMinutes(15))
    {
        if (baslangic.Hour == 12) continue;
        DateTime ikinci = baslangic2.AddMinutes(15);
        Console.WriteLine($"{baslangic2:hh:mm} - {ikinci:hh:mm} {baslangic2:tt}");

    }