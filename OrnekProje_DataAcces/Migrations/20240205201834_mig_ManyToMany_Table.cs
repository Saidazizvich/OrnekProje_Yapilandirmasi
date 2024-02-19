using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OrnekProje_DataAcces.Migrations
{
    public partial class mig_ManyToMany_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FluentApiBook_Writers",
                columns: table => new
                {
                    WriterId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FluentApiBook_Writers", x => new { x.WriterId, x.BookId });
                    table.ForeignKey(
                        name: "FK_FluentApiBook_Writers_FluentApiBooks_BookId",
                        column: x => x.BookId,
                        principalTable: "FluentApiBooks",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FluentApiBook_Writers_FluentApiWriters_WriterId",
                        column: x => x.WriterId,
                        principalTable: "FluentApiWriters",
                        principalColumn: "WriterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FluentApiBook_Writers_BookId",
                table: "FluentApiBook_Writers",
                column: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FluentApiBook_Writers");
        }
    }
}
