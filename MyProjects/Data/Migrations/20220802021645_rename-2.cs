using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyProjects.Data.Migrations
{
    public partial class rename2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Roles",
                newSchema: "security");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Roles",
                schema: "security",
                newName: "Roles");
        }
    }
}
