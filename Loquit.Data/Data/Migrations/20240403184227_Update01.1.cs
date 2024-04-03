using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Loquit.Data.Migrations
{
    /// <inheritdoc />
    public partial class Update011 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsSpolier",
                table: "Posts",
                newName: "IsSpoiler");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsSpoiler",
                table: "Posts",
                newName: "IsSpolier");
        }
    }
}
