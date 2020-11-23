using System;
using System.Collections.Generic;
using System.Text;
using Elkoob.Domain.Entities.CategoryAndProduct;
using Microsoft.EntityFrameworkCore;

namespace Elkoob.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ProductToCategory> ProductToCategories { get; set; }
        DbSet<Item> Items { get; set; }
    }
}
