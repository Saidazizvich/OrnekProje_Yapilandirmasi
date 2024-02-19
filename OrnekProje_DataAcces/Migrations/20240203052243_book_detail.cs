using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrnekProje_DataAcces.Migrations
{
    public partial class book_detail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookDetailsId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    BookDetailsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumberofChapters = table.Column<int>(type: "int", nullable: false),
                    ChapterPage = table.Column<int>(type: "int", nullable: false),
                    BookDetailsWeight = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetails", x => x.BookDetailsId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookDetailsId",
                table: "Books",
                column: "BookDetailsId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookDetails_BookDetailsId",
                table: "Books",
                column: "BookDetailsId",
                principalTable: "BookDetails",
                principalColumn: "BookDetailsId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookDetails_BookDetailsId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookDetailsId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookDetailsId",
                table: "Books");
        }
    }
}
