using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Methodlar kendimizi tekrar  etmememizi sağlar. DONT REPEAT YOURSELF-DRY-Clean Code

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            //Class'dan bir değişken tanımlanacağı zaman yapılması gereken:
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] {urun1,urun2};

            //type safe
            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine("------------------");
            }

            //instance-Class örnek oluşturmak
            //encapsulation
            Console.WriteLine("-----------------METOTLAR--------------");
            Sepet_Manager sepetManager = new Sepet_Manager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);

            


        }
    }
}
