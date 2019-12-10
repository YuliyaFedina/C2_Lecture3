using System;
using System.IO;

namespace HomeWork.Infrastructure
{
    internal class FileLogger : ILogger
    {
        public void Log(Exception e)
        {
            File.AppendAllText("log.txt", e.Message);
        }
    }
}