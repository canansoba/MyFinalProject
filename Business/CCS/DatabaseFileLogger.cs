using System;

namespace Business.CCS
{
    public class DatabaseFileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
