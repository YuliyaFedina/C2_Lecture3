using System;

namespace HomeWork.Infrastructure
{
    internal interface ILogger
    {
        void Log(Exception e);
    }
}