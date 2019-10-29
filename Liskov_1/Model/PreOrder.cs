﻿using System;

namespace Liskov_1.Model
{
    public class PreOrder : Order
    {
        public string Description { get; set; }

        public override decimal GetSum()
        {
            throw new NotSupportedException();
        }
    }
}
