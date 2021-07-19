using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();           
            IKrediManager tasitKrediManager = new TasitKrediManager();           
            IKrediManager konukKrediManager = new KonukKrediManager();

            ILoggerServivce databaseLoggerManager = new DatabaseLoggerService();
            ILoggerServivce fileLoggerManager = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyacKrediManager,fileLoggerManager);



            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
