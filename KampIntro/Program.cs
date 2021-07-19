using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[]
                {
                    urun1,urun2
                };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Adı : "+urun.Adi + " Fiyatı : " +urun.Fiyati + " Açıklma : "+ urun.Aciklama);
            }






        }
    }
}
