using System;

int sayac = 0;
Console.WriteLine("Cikti almak istediginiz miktari giriniz.");
int i = Convert.ToInt32(Console.ReadLine());
while (sayac <= i)
{
    Console.WriteLine("|Sayac={0}| Ben bir Patika'liyim.", sayac);
    sayac++;
}
sayac = 0;
while (sayac >= i)
{
    int sonucWhile = -sayac;
    Console.WriteLine("|Sayac={0}| Ben bir Patika'liyim.", sonucWhile);                     // 0'dan artarak gitmeli diye belirtildigi icin
    sayac--;                                                                                // - den + ya sayacin sonucu degistirilerek ataniyor
}

Console.WriteLine("=====================Do While ile kullanimi=========================");
int sonucDoWhile;
sayac = 0;
Console.WriteLine("Cikti almak istediginiz miktari giriniz.");
int b = Convert.ToInt32(Console.ReadLine());
do
{
    switch (b > 0)
    {
        case true:
            sonucDoWhile = sayac;
            Console.WriteLine("|Sayac={0}| Ben bir Patika'liyim.", sonucDoWhile);          // Nested yazmaya calistim, degisken b sabit girdi olarak
            sayac++;                                                                       // kalacagi icin, + ve - ile etkilesime gecmis hallerini
            break;                                                                         // bireysel olarak atayamadim. Bu yuzden sonucDoWhile
        case false:                                                                        // loopun "disinda" calisip uzerine bir ekleyerek, iki olasiligi da
            sonucDoWhile = -sayac;                                                         // + ve - girdi durumunda, girdi sekli odev aciklmasinda oldugu gibi
            Console.WriteLine("|Sayac={0}| Ben bir Patika'liyim.", sonucDoWhile);          // 0' dan baslayarak girdi limitine kadar ciktiyi alabiliyor.         
            sayac--;                                                                       // daha kolay yolunu bilen, not dusebilirse sevinirim.
            break;
    }                                                                                      // (cozemedigim bir nedenden dolayi do while ile hep bir eksik
} while (sayac != b);
Console.WriteLine("|Sayac={0}| Ben bir Patika'liyim.",sonucDoWhile + 1);                   //cikti alabildim.)    

