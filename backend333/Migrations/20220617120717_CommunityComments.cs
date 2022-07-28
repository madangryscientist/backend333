using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend333.Migrations
{
    public partial class CommunityComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comment",
                table: "Community");

            migrationBuilder.CreateTable(
                name: "CommunityComment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Comment = table.Column<string>(type: "TEXT", nullable: false),
                    CommunityId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommunityComment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CommunityComment_Community_CommunityId",
                        column: x => x.CommunityId,
                        principalTable: "Community",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommunityComment_CommunityId",
                table: "CommunityComment",
                column: "CommunityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommunityComment");

            migrationBuilder.AddColumn<string>(
                name: "Comment",
                table: "Community",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}
