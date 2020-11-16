using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFirstNews.Migrations
{
    public partial class Extension : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Extension",
                table: "NewsImages",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Extension",
                table: "NewsImages");
        }
    }
}
