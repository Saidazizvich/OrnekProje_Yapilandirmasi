using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrnekProje_DataAcces.Migrations
{
    public partial class book_fluentapi_category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_tb_Category_CategoryId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_Category",
                table: "tb_Category");

            migrationBuilder.RenameTable(
                name: "tb_Category",
                newName: "tbl_CategoryNew");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbl_CategoryNew",
                table: "tbl_CategoryNew",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_tbl_CategoryNew_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "tbl_CategoryNew",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_tbl_CategoryNew_CategoryId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbl_CategoryNew",
                table: "tbl_CategoryNew");

            migrationBuilder.RenameTable(
                name: "tbl_CategoryNew",
                newName: "tb_Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_Category",
                table: "tb_Category",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_tb_Category_CategoryId",
                table: "Books",
                column: "CategoryId",
                principalTable: "tb_Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
