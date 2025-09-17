using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValasztasWebApp.Migrations
{
    /// <inheritdoc />
    public partial class sqlitelocal_migration_247 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Szavazat",
                table: "Jeloltek",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Szavazat",
                table: "Jeloltek");
        }
    }
}
