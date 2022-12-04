using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PustokLayout.Migrations
{
    public partial class IsSNColumnCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNew",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsSpecial",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNew",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "IsSpecial",
                table: "Books");
        }
    }
}
