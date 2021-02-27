using System;

namespace Dongulerr
{
    class Program
    {
        static void Main(string[] args)
        {

            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            

            //array 

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs" , "Java" , "Python"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("FOR BİTTİ");

            foreach (string kurs in kurslar) //Dizilere uygulanır. Dizi elemanlarını tek tek dolaşır. 
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu");

        }
    }
}
