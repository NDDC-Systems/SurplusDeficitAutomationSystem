using Microsoft.EntityFrameworkCore.Migrations;

namespace SurplusDeficitAutomationSystem.Migrations.AppDb
{
    public partial class doublejump : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProviderId",
                table: "Reports",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "IntFields",
                columns: table => new
                {
                    IntFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IntValue = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntFields", x => x.IntFieldId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ProviderId",
                table: "Reports",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Providers_ProviderId",
                table: "Reports",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Providers_ProviderId",
                table: "Reports");

            migrationBuilder.DropTable(
                name: "IntFields");

            migrationBuilder.DropIndex(
                name: "IX_Reports_ProviderId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "Reports");
        }
    }
}
