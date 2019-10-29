using System;
using System.IO;

namespace SRP_2.Infrastructure
{
    internal class FileLogger
    {
        public void Log(Exception e)
        {
            File.AppendAllText("log.txt", e.Message);
        }
    }
}
