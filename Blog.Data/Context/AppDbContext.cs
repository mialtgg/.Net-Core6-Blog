using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.dATA.Context
{
    public class AppDbContext :  DbContext
    {

        protected AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet <Category>Categories {get; set;}

        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            //DB ye veri değişikliği işlemini böyle de yapabiliriz ancak bu  clean code mantığına aykırıdır
            //çok nadir kullanılır , map sınıflarında tanımlamamaız daha iyi olacaktır
            //builder.Entity<Article>().Property(x => x.Title).HasMaxLength(150);


            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
