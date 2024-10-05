using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class MoviesInDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Name", "Released" },
                values: new object[] { 1, "\"Se7en\" (1995) is a psychological thriller directed by David Fincher, featuring a grim and intense narrative. The film stars Brad Pitt as Detective David Mills and Morgan Freeman as Detective William Somerset, two detectives on a hunt for a serial killer who uses the seven deadly sins as his modus operandi.", "Se7en", 1995 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
