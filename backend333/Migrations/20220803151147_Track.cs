using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend333.Migrations
{
    public partial class Track : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Track",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TrackName = table.Column<string>(type: "TEXT", nullable: false),
                    Bpm = table.Column<int>(type: "INTEGER", nullable: false),
                    Tune = table.Column<string>(type: "TEXT", nullable: false),
                    SongUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Track", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Track");
        }
    }
}
