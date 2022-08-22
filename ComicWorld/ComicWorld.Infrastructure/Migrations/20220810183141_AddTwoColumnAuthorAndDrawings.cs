using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicWorld.Infrastructure.Migrations
{
    public partial class AddTwoColumnAuthorAndDrawings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Comics",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Drawings",
                table: "Comics",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "Comics");

            migrationBuilder.DropColumn(
                name: "Drawings",
                table: "Comics");
        }
    }
}
