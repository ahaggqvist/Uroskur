using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uroskur.DataAccess.Migrations
{
    public partial class Addgoogleusers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "google_users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    Mail = table.Column<string>(type: "TEXT", nullable: true),
                    StravaUserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_google_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_google_users_strava_users_StravaUserId",
                        column: x => x.StravaUserId,
                        principalTable: "strava_users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_google_users_StravaUserId",
                table: "google_users",
                column: "StravaUserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "google_users");
        }
    }
}
