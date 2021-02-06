using System;
using System.Collections.Generic;
using System.Text;

using Entities.Concrete;

using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
  public  class GalleryContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Gallery;Trusted_Connection=True");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        



    }
}
