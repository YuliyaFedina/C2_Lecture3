using System;
using System.IO;

namespace DependencyInversion_2.Infrastructure
{
    internal class FileLogger : ILogger
    {
        public void Log(Exception e)
        {
            File.AppendAllText("log.txt", e.Message);
        }
    }
}
