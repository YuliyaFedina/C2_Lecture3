using System;

namespace HomeWork.Model
{
    internal class Contact : IEntity
    {
        public long Id { get; set; }
        public virtual string Value { get; set; }
    }
}
