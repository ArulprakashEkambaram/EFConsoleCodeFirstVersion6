using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDBFirst.Migrations
{
    /// <inheritdoc />
    public partial class AddManagerforOnetoManyRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dept",
                table: "Managers",
                newName: "Department");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Managers",
                newName: "Dept");
        }
    }
}
