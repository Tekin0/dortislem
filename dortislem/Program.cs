using System;

namespace dortislem
{
    class Program : tfb.tfb
    {
      
        static void Main(string[] args)
        {
            altayaz("Tfb Progamlama Diline Hoşgeldiniz");
            altayaz("Bu projemizde dört işlem yapılacaktır");
            altayaz("Programlama dilimiz C ailesine mensuptur.C# ile Beraber kullanılabilir");
            altayaz("if yerine eger,for yerine dongu kullanılabilir");
            bool durum = eger("1", "==", "2");
            if (durum)
            {
                dongu(1, 20, 1, "<", "*"); yaz("Dört işlem Programı"); dongu(1, 20, 1, "<", "*");
            }
            else
            {
                dongu(1, 50, 1, "<", "#"); yaz("Dört işlem Programı"); dongu(1, 50, 1, "<", "#");
            }
            altayaz("");
            altayaz("Sayı 1 Giriniz");
            object sayi1 = sayicek();
            altayaz("Sayı 2 Giriniz");
            object sayi2 = sayicek();
            altayaz("İki sayının toplamı işlemi : " + topla(sayi1,sayi2).ToString());

            altayaz("İki sayının çıkarma işlemi : " + cikar(sayi1, sayi2).ToString());
      
            altayaz("İki sayının bölme işlemi : " + bol(sayi1, sayi2).ToString());
      
            altayaz("İki sayının çarpma işlemi: " + carp(sayi1, sayi2).ToString());
     
            altayaz("İki sayının Mod alma : " + mod(sayi1, sayi2).ToString());


            durdur();
        }

        
    }
}
