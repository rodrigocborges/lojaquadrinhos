using LojaQuadrinhos.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LojaQuadrinhos.Contexts
{
    public class ShopContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Password=785532;Persist Security Info=True;User ID=rodrigoborges;Initial Catalog=LojaQuadrinhos;Data Source=DESKTOP-0K750DP\SQLEXPRESS");
        }
    }
}
