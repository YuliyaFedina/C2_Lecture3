using System;
using System.IO;

namespace DependencyInversion_1.Infrastructure
{
    internal class FileLogger
    {
        public void Log(Exception e)
        {
            File.AppendAllText("log.txt", e.Message);
        }
    }
}
