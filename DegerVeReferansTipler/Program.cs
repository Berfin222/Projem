using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi=30

            
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0]=999 sayılar1 in referans numarası sayilar2 nin referans numarasına eşitlendiği için
            //sayilar1, sayilar2'nin değişikliklerinden etkilenir. sayilar1'in referans değerine sahip elemanlar bellekten atılır.

            //int,decimal,float,decimal,bool=değer tip
            //array,class,interface=referans tip
            //bellekte değer tipleri stack kısmında, referans tipleri heap kısmında gerçekleşir. 
        }
    }
}
