﻿//ÇOK BOYUTLU DİZİLER

int[,,] dizi2 = new int[3, 3, 3]; //3 boyutlu dizi
int[,] dizi = new int[2, 2]; //2 boyutlu dizi

dizi[0, 0] = 1;
dizi[0, 1] = 2;
dizi[1, 0] = 3;
dizi[1, 1] = 4;

Random rnd = new();
//2 Boyutlu.
//3 boyutlu için içe içe 3 for döngüsü kullanılır.
//Depug--> Windows-->Immediate alt ekranda çalıştırırken çıktıyı görmek için
for (int i = 0; i < dizi.GetLength(0); i++)
{
    for (int j=0; j<dizi.GetLength(1); j++)
    {
        dizi[i, j] = rnd.Next();
    }
}
Console.WriteLine();