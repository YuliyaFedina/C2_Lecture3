using System;

namespace DependencyInversion_2.Infrastructure
{
    internal interface ILogger
    {
        void Log(Exception e);
    }
}