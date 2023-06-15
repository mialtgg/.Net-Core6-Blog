using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Net.Mime.MediaTypeNames;

namespace Blog.dATA.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title="Asp.net Core Deneme Makalesi 1",
                Content= "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ViewCount=15,
                CategoryId = Guid.Parse("2ECC8C8F-9941-4598-8ABB-214D70D5B371"),
                ImageId = Guid.Parse("2ECC8C8F-9941-4598-8ABB-214D70D5B371")





            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio  Deneme Makalesi 1",
                Content = "Visual Studio of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.",
                ViewCount = 10,
                CategoryId = Guid.Parse("432FA168-17F5-4F36-8437-5A9E4B8C1863"),
                ImageId = Guid.Parse("432FA168-17F5-4F36-8437-5A9E4B8C1863")


            }) ;
        }

    }
}
