using System;
using System.Collections.Generic;
using System.Text;

namespace Elkoob.Domain.Entities.CategoryAndProduct
{
    public class Item
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
