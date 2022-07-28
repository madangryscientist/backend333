using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend333.Migrations
{
    public partial class CreateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SocialMedia",
                table: "ContactUs",
                newName: "Twitter");

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "ContactUs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SoundCloud",
                table: "ContactUs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "ContactUs");

            migrationBuilder.DropColumn(
                name: "SoundCloud",
                table: "ContactUs");

            migrationBuilder.RenameColumn(
                name: "Twitter",
                table: "ContactUs",
                newName: "SocialMedia");
        }
    }
}
