using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.dATA.Migrations
{
    /// <inheritdoc />
    public partial class setupDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("c8b2a8ca-7539-4857-a454-ec8d36f0280c"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dca6b836-e881-4d0a-beb8-2f4add700c96"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DelatedBy", "DelatedDate", "ImageId", "IsDelate", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("6719d5c4-cb83-4b84-b6f6-66f6696cba9b"), new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"), "Visual Studio of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, new DateTime(2023, 6, 23, 10, 7, 21, 621, DateTimeKind.Local).AddTicks(442), null, null, new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"), false, null, null, "Visual Studio  Deneme Makalesi 1", 10 },
                    { new Guid("d4d5fc25-bffa-4b10-92fe-9511dd433194"), new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, new DateTime(2023, 6, 23, 10, 7, 21, 621, DateTimeKind.Local).AddTicks(422), null, null, new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 23, 10, 7, 21, 621, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 23, 10, 7, 21, 621, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 23, 10, 7, 21, 621, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 23, 10, 7, 21, 621, DateTimeKind.Local).AddTicks(725));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("6719d5c4-cb83-4b84-b6f6-66f6696cba9b"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("d4d5fc25-bffa-4b10-92fe-9511dd433194"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "CategoryId", "Content", "CreatedBy", "CreatedDate", "DelatedBy", "DelatedDate", "ImageId", "IsDelate", "ModifiedBy", "ModifiedDate", "Title", "ViewCount" },
                values: new object[,]
                {
                    { new Guid("c8b2a8ca-7539-4857-a454-ec8d36f0280c"), new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"), "Visual Studio of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, new DateTime(2023, 6, 15, 13, 28, 40, 8, DateTimeKind.Local).AddTicks(5904), null, null, new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"), false, null, null, "Visual Studio  Deneme Makalesi 1", 10 },
                    { new Guid("dca6b836-e881-4d0a-beb8-2f4add700c96"), new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"), "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.", null, new DateTime(2023, 6, 15, 13, 28, 40, 8, DateTimeKind.Local).AddTicks(5882), null, null, new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"), false, null, null, "Asp.net Core Deneme Makalesi 1", 15 }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 15, 13, 28, 40, 8, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 15, 13, 28, 40, 8, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("2ecc8c8f-9941-4598-8abb-214d70d5b371"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 15, 13, 28, 40, 8, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("432fa168-17f5-4f36-8437-5a9e4b8c1863"),
                column: "CreatedDate",
                value: new DateTime(2023, 6, 15, 13, 28, 40, 8, DateTimeKind.Local).AddTicks(6170));
        }
    }
}
