using System;

namespace SRP_1.Infrastructure
{
    public interface ILogger
    {
        void Log(Exception e);
    }
}