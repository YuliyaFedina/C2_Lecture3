using System;

namespace HomeWork.Infrastructure
{
    public interface IHandler
    {
        void Handle(Exception e);
    }
}