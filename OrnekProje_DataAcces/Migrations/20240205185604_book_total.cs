using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrnekProje_DataAcces.Migrations
{
    public partial class book_total : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "tb_Category",
                newName: "Ad");

            migrationBuilder.CreateTable(
                name: "FluentApiBookDetails",
                columns: table => new
                {
                    DetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberofChapters = table.Column<int>(type: "int", nullable: false),
                    ChapterPage = table.Column<int>(type: "int", nullable: false),
                    BookDetailWeight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApiBookDetails", x => x.DetailId);
                });

            migrationBuilder.CreateTable(
                name: "FluentApiPublishers",
                columns: table => new
                {
                    PublisherId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApiPublishers", x => x.PublisherId);
                });

            migrationBuilder.CreateTable(
                name: "FluentApiWriters",
                columns: table => new
                {
                    WriterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WriterName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WriterSurName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApiWriters", x => x.WriterId);
                });

            migrationBuilder.CreateTable(
                name: "FluentApiBooks",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DiscountPrice = table.Column<double>(type: "float", nullable: false),
                    Barkod = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    DetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApiBooks", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_FluentApiBooks_FluentApiBookDetails_DetailId",
                        column: x => x.DetailId,
                        principalTable: "FluentApiBookDetails",
                        principalColumn: "DetailId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FluentApiBooks_DetailId",
                table: "FluentApiBooks",
                column: "DetailId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentApiBooks");

            migrationBuilder.DropTable(
                name: "FluentApiPublishers");

            migrationBuilder.DropTable(
                name: "FluentApiWriters");

            migrationBuilder.DropTable(
                name: "FluentApiBookDetails");

            migrationBuilder.RenameColumn(
                name: "Ad",
                table: "tb_Category",
                newName: "Name");
        }
    }
}
