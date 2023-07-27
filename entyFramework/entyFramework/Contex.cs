using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entyFramework
{
    internal class Contex : DbContext
    {
         public DbSet<User> Users { get; set; }

         public DbSet<House> Houses { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=DESKTOP-HGDM54L; Database=frame_test2; Trusted_Connection=True; Encrypt=False");

        }
    }
}
