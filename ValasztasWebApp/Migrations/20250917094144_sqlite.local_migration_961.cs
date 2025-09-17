using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValasztasWebApp.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_961 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jeloltek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Kerulet = table.Column<int>(type: "INTEGER", nullable: false),
                    Nev = table.Column<string>(type: "TEXT", nullable: false),
                    Part = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jeloltek", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jeloltek");
        }
    }
}
