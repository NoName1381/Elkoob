using System;
using System.Collections.Generic;
using System.Text;

namespace Elkoob.Domain.Entities.CategoryAndProduct
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<ProductToCategory> ProductToCategories { get; set; }
    }
}
