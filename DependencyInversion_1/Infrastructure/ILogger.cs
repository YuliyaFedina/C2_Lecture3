using System;

namespace DependencyInversion_1.Infrastructure
{
    internal interface ILogger
    {
        void Log(Exception e);
    }
}