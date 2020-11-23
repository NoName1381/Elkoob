using System;
using System.Collections.Generic;
using System.Text;

namespace Elkoob.Domain.Entities.CategoryAndProduct
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ItemId { get; set; }

        public Item Item { get; set; }
        public ICollection<ProductToCategory> ProductToCategories { get; set; }
    }
}
