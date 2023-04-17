using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DevShop.Models.Product;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DevShop.Data
{
    public class DevShopContext : IdentityDbContext
    {
        public DevShopContext (DbContextOptions<DevShopContext> options)
            : base(options)
        {
        }

        public DbSet<DevShop.Models.Product.Product> Product { get; set; } = default!;
    }
}
