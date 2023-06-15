using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.dATA.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("2ECC8C8F-9941-4598-8ABB-214D70D5B371"),
                FileName = "images/testimage",
                FileType = "jpeg",
                CreatedBy = "Admin Test",
                IsDelate = false

            },
            new Image
            {
                Id = Guid.Parse("432FA168-17F5-4F36-8437-5A9E4B8C1863"),
                FileName = "images/vstesttestimage",
                FileType = "png",
                CreatedBy = "Admin Test",
                IsDelate = false

            });
        }
    }
}
