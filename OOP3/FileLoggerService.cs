using System;

namespace OOP3
{
    class FileLoggerService : ILoggerServivce
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya Loglandı.");
        }
    }
}
