using Microsoft.EntityFrameworkCore.Migrations;

namespace SurplusDeficitAutomationSystem.Migrations.AppDb
{
    public partial class UpdateReport7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Admin",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "Provider",
                table: "Reports");

            migrationBuilder.AddColumn<int>(
                name: "AdminId",
                table: "Reports",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TemplateId",
                table: "Reports",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "TemplateId",
                table: "Reports");

            migrationBuilder.AddColumn<string>(
                name: "Admin",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Provider",
                table: "Reports",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
