using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.dATA.Migrations
{
    /// <inheritdoc />
    public partial class SeedComplaated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DelatedBy", "DelatedDate", "IsDelate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"), "Admin Test", new DateTime(2023, 6, 15, 13, 28, 40, 8, DateTimeKind.Local).AddTicks(6081), null, null, false, null, null, "ASP .NET Core" },
                    { new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"), "Admin Test", new DateTime(2023, 6, 15, 13, 28, 40, 8, DateTimeKind.Local).AddTicks(6084), null, null, false, null, null, "Visual Studio" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "DelatedBy", "DelatedDate", "FileName", "FileType", "IsDelate", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"), "Admin Test", new DateTime(2023, 6, 15, 13, 28, 40, 8, DateTimeKind.Local).AddTicks(6165), null, null, "images/testimage", "jpeg", false, null, null },
                    { new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"), "Admin Test", new DateTime(2023, 6, 15, 13, 28, 40, 8, DateTimeKind.Local).AddTicks(6170), null, null, "images/vstesttestimage", "png", false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DelatedBy", "DelatedDate", "ImageId", "IsDelate", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("c8b2a8ca-7539-4857-a454-ec8d36f0280c"), new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"), "Visual Studio of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, new DateTime(2023, 6, 15, 13, 28, 40, 8, DateTimeKind.Local).AddTicks(5904), null, null, new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"), false, null, null, "Visual Studio  Deneme Makalesi 1", 10 },
                    { new Guid("dca6b836-e881-4d0a-beb8-2f4add700c96"), new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, new DateTime(2023, 6, 15, 13, 28, 40, 8, DateTimeKind.Local).AddTicks(5882), null, null, new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c8b2a8ca-7539-4857-a454-ec8d36f0280c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dca6b836-e881-4d0a-beb8-2f4add700c96"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"));

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Articles",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
