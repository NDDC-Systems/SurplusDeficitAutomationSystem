using Microsoft.EntityFrameworkCore.Migrations;

namespace SurplusDeficitAutomationSystem.Migrations.AppDb
{
    public partial class contractName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContractName",
                table: "Contracts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TemplateToField",
                columns: table => new
                {
                    TemplateToFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    FieldId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemplateToField", x => x.TemplateToFieldId);
                    table.ForeignKey(
                        name: "FK_TemplateToField_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "FieldId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TemplateToField_Templates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "Templates",
                        principalColumn: "TemplateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_AdminId",
                table: "Reports",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateToField_FieldId",
                table: "TemplateToField",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_TemplateToField_TemplateId",
                table: "TemplateToField",
                column: "TemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Admins_AdminId",
                table: "Reports",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "AdminId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Admins_AdminId",
                table: "Reports");

            migrationBuilder.DropTable(
                name: "TemplateToField");

            migrationBuilder.DropIndex(
                name: "IX_Reports_AdminId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "ContractName",
                table: "Contracts");
        }
    }
}
