using Microsoft.EntityFrameworkCore.Migrations;

namespace ComicWorld.Infrastructure.Migrations
{
    public partial class AddComicPhotoColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ComicPhoto",
                table: "Comics",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComicPhoto",
                table: "Comics");
        }
    }
}
