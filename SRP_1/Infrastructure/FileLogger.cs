using System;
using System.IO;

namespace SRP_1.Infrastructure
{
    public class FileLogger : ILogger
    {
    public void Log(Exception e)
    {
        File.AppendAllText("log.txt", e.Message);
    }
    }
}
