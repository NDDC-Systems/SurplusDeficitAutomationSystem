using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SurplusDeficitAutomationSystem.Migrations.AppDb
{
    public partial class fieldmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reports_Providers_ProviderId",
                table: "Reports");

            migrationBuilder.DropIndex(
                name: "IX_Reports_ProviderId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "FieldName",
                table: "StringFields");

            migrationBuilder.DropColumn(
                name: "ProviderId",
                table: "Reports");

            migrationBuilder.DropColumn(
                name: "FieldName",
                table: "IntFields");

            migrationBuilder.DropColumn(
                name: "DataType",
                table: "Fields");

            migrationBuilder.RenameColumn(
                name: "TemplateId",
                table: "StringFields",
                newName: "FieldId");

            migrationBuilder.RenameColumn(
                name: "TemplateId",
                table: "IntFields",
                newName: "FieldId");

            migrationBuilder.CreateTable(
                name: "BooleanFields",
                columns: table => new
                {
                    BooleanFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldId = table.Column<int>(type: "int", nullable: false),
                    BooleanValue = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooleanFields", x => x.BooleanFieldId);
                    table.ForeignKey(
                        name: "FK_BooleanFields_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "FieldId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DateTimeFields",
                columns: table => new
                {
                    DateTimeFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldId = table.Column<int>(type: "int", nullable: false),
                    DateTimeValue = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateTimeFields", x => x.DateTimeFieldId);
                    table.ForeignKey(
                        name: "FK_DateTimeFields_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "FieldId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FloatFields",
                columns: table => new
                {
                    FloatFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldId = table.Column<int>(type: "int", nullable: false),
                    FloatValue = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FloatFields", x => x.FloatFieldId);
                    table.ForeignKey(
                        name: "FK_FloatFields_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "FieldId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TextFields",
                columns: table => new
                {
                    TextFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FieldId = table.Column<int>(type: "int", nullable: false),
                    TextValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TextFields", x => x.TextFieldId);
                    table.ForeignKey(
                        name: "FK_TextFields_Fields_FieldId",
                        column: x => x.FieldId,
                        principalTable: "Fields",
                        principalColumn: "FieldId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StringFields_FieldId",
                table: "StringFields",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_IntFields_FieldId",
                table: "IntFields",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_BooleanFields_FieldId",
                table: "BooleanFields",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_DateTimeFields_FieldId",
                table: "DateTimeFields",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_FloatFields_FieldId",
                table: "FloatFields",
                column: "FieldId");

            migrationBuilder.CreateIndex(
                name: "IX_TextFields_FieldId",
                table: "TextFields",
                column: "FieldId");

            migrationBuilder.AddForeignKey(
                name: "FK_IntFields_Fields_FieldId",
                table: "IntFields",
                column: "FieldId",
                principalTable: "Fields",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StringFields_Fields_FieldId",
                table: "StringFields",
                column: "FieldId",
                principalTable: "Fields",
                principalColumn: "FieldId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IntFields_Fields_FieldId",
                table: "IntFields");

            migrationBuilder.DropForeignKey(
                name: "FK_StringFields_Fields_FieldId",
                table: "StringFields");

            migrationBuilder.DropTable(
                name: "BooleanFields");

            migrationBuilder.DropTable(
                name: "DateTimeFields");

            migrationBuilder.DropTable(
                name: "FloatFields");

            migrationBuilder.DropTable(
                name: "TextFields");

            migrationBuilder.DropIndex(
                name: "IX_StringFields_FieldId",
                table: "StringFields");

            migrationBuilder.DropIndex(
                name: "IX_IntFields_FieldId",
                table: "IntFields");

            migrationBuilder.RenameColumn(
                name: "FieldId",
                table: "StringFields",
                newName: "TemplateId");

            migrationBuilder.RenameColumn(
                name: "FieldId",
                table: "IntFields",
                newName: "TemplateId");

            migrationBuilder.AddColumn<string>(
                name: "FieldName",
                table: "StringFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProviderId",
                table: "Reports",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FieldName",
                table: "IntFields",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DataType",
                table: "Fields",
                type: "nvarchar(max)",
                nullable: true);

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
    }
}
