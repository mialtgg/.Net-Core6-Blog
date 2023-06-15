using Blog.Entity.Entities;
using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Blog.dATA.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("2ECC8C8F-9941-4598-8ABB-214D70D5B371"),
                Name = "ASP .NET Core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDelate = false

            },
            new Category
            {

                Id = Guid.Parse("432FA168-17F5-4F36-8437-5A9E4B8C1863"),
                Name = "Visual Studio",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDelate = false

             ,
            }
            );
        }
    }
}
