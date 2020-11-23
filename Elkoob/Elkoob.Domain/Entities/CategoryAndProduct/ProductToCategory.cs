using System;
using System.Collections.Generic;
using System.Text;

namespace Elkoob.Domain.Entities.CategoryAndProduct
{
    public class ProductToCategory
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        // Navigation properties
        public Product Product { get; set; }
        public Category Category { get; set; }
    }
}
