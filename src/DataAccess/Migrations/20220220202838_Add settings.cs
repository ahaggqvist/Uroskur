using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Uroskur.DataAccess.Migrations
{
    public partial class Addsettings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "google_users");

            migrationBuilder.CreateTable(
                name: "settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: true),
                    ClientSecret = table.Column<string>(type: "TEXT", nullable: true),
                    AppId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_settings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "settings");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "google_users",
                type: "INTEGER",
                nullable: true);
        }
    }
}
