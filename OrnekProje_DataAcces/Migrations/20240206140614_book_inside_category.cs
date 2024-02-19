using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrnekProje_DataAcces.Migrations
{
    public partial class book_inside_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tbl_CategoryNew",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Scared" },
                    { 2, "Horror" },
                    { 3, "Comedy" },
                    { 4, "Drama" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tbl_CategoryNew",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tbl_CategoryNew",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "tbl_CategoryNew",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tbl_CategoryNew",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
