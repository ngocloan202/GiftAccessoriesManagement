using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GiftAccessoriesManagement.Models;

namespace GiftAccessoriesManagement.Data
{
    public class GiftAccessoriesManagementContext : DbContext
    {
        public GiftAccessoriesManagementContext (DbContextOptions<GiftAccessoriesManagementContext> options)
            : base(options)
        {
        }

        public DbSet<GiftAccessoriesManagement.Models.Product> Product { get; set; } = default!;
    }
}
