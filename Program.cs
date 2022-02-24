using System;

namespace while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            // birden başlayrak consoledaa girilen sayıda dahil olsun ortalma hesaplayıp console yazdıran program.
            // consoleden hangi sayıya kadar alacagımızı belirliyoruz
            Console.Write("Lütfen bir sayi giriniz:");

            int sayi= int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam =0; // ortalama için gerekli 
            while(sayac<=sayi)
            {
                toplam += sayac;
                sayac ++; // burda artırmam gerekiyor ki sonsuz donguye girmesin



            }
            Console.WriteLine(toplam/sayi);
            // a'dan z ye kadar tüm harfleri console yazdıralım 
            char character = 'a';

            while (character <'z')
            {
                Console.Write(character);
                character++;
            }
            Console.Write("******Foreach******");
            string[] arabalar ={"Bmw","Ford","nissan","toyata"}; 
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
