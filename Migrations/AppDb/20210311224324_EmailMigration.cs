using Microsoft.EntityFrameworkCore.Migrations;

namespace SurplusDeficitAutomationSystem.Migrations.AppDb
{
    public partial class EmailMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Providers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Admins",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Providers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Admins");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Admins");
        }
    }
}
