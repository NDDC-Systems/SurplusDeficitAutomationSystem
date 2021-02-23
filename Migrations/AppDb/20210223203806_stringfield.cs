using Microsoft.EntityFrameworkCore.Migrations;

namespace SurplusDeficitAutomationSystem.Migrations.AppDb
{
    public partial class stringfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Providers");

            migrationBuilder.AlterColumn<int>(
                name: "ProviderId",
                table: "Contracts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "ProviderToContract",
                columns: table => new
                {
                    ProviderToContractId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProviderId = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProviderToContract", x => x.ProviderToContractId);
                    table.ForeignKey(
                        name: "FK_ProviderToContract_Contracts_ContractId",
                        column: x => x.ContractId,
                        principalTable: "Contracts",
                        principalColumn: "ContractId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProviderToContract_Providers_ProviderId",
                        column: x => x.ProviderId,
                        principalTable: "Providers",
                        principalColumn: "ProviderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StringFields",
                columns: table => new
                {
                    StringFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateId = table.Column<int>(type: "int", nullable: false),
                    FieldName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StringValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StringFields", x => x.StringFieldId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ContractId",
                table: "Reports",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_TemplateId",
                table: "Reports",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_ProviderId",
                table: "Contracts",
                column: "ProviderId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderToContract_ContractId",
                table: "ProviderToContract",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_ProviderToContract_ProviderId",
                table: "ProviderToContract",
                column: "ProviderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Providers_ProviderId",
                table: "Contracts",
                column: "ProviderId",
                principalTable: "Providers",
                principalColumn: "ProviderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Contracts_ContractId",
                table: "Reports",
                column: "ContractId",
                principalTable: "Contracts",
                principalColumn: "ContractId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_Templates_TemplateId",
                table: "Reports",
                column: "TemplateId",
                principalTable: "Templates",
                principalColumn: "TemplateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Providers_ProviderId",
                table: "Contracts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Contracts_ContractId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Templates_TemplateId",
                table: "Reports");

            migrationBuilder.DropTable(
                name: "ProviderToContract");

            migrationBuilder.DropTable(
                name: "StringFields");

            migrationBuilder.DropIndex(
                name: "IX_Reports_ContractId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_TemplateId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_ProviderId",
                table: "Contracts");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Providers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProviderId",
                table: "Contracts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
