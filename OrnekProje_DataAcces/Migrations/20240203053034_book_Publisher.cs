using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrnekProje_DataAcces.Migrations
{
    public partial class book_Publisher : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookDetailsWeight",
                table: "BookDetails",
                newName: "BookDetailWeight");

            migrationBuilder.RenameColumn(
                name: "BookDetailsId",
                table: "BookDetails",
                newName: "BookDetailId");

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherId",
                table: "Books",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Publishers_PublisherId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_PublisherId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Books");

            migrationBuilder.RenameColumn(
                name: "BookDetailWeight",
                table: "BookDetails",
                newName: "BookDetailsWeight");

            migrationBuilder.RenameColumn(
                name: "BookDetailId",
                table: "BookDetails",
                newName: "BookDetailsId");
        }
    }
}
