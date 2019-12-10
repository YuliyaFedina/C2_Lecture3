﻿using System;

namespace Liskov_1.Model
{
    public class PreOrder : IPreOrder
    {
        public long Id { get; set; }

        public int OrderNumber { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public long UserId { get; set; }

        public string Description { get; set; }

    }
}
