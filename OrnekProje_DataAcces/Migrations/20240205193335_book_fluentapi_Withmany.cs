using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrnekProje_DataAcces.Migrations
{
    public partial class book_fluentapi_Withmany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "FluentApiBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FluentApiBooks_PublisherId",
                table: "FluentApiBooks",
                column: "PublisherId");

            migrationBuilder.AddForeignKey(
                name: "FK_FluentApiBooks_FluentApiPublishers_PublisherId",
                table: "FluentApiBooks",
                column: "PublisherId",
                principalTable: "FluentApiPublishers",
                principalColumn: "PublisherId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FluentApiBooks_FluentApiPublishers_PublisherId",
                table: "FluentApiBooks");

            migrationBuilder.DropIndex(
                name: "IX_FluentApiBooks_PublisherId",
                table: "FluentApiBooks");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "FluentApiBooks");
        }
    }
}
