﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerServivce
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Loglandı.");
        }
    }
}
