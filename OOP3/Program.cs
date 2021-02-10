using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();  
            IKrediManager tasitKrediManager = new TasitKrediManager();      
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService loggerService = new DatabaseLoggerService();
            ILoggerService loggerService1 = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> {new DatabaseLoggerService(),new SmsLoggerService()};

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, loggers);

            List<IKrediManager> krediler = new List<IKrediManager> { ıhtiyacKrediManager, tasitKrediManager, konutKrediManager };
          

            //**Interfaceler de o interface'e implemente eden classın referans numarasını tutabiliyor.**
        }
    }
}
