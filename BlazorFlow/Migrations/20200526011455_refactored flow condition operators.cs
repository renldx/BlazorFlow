using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlazorFlow.Migrations
{
    public partial class refactoredflowconditionoperators : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowConditionValues");

            migrationBuilder.CreateTable(
                name: "FlowConditions",
                columns: table => new
                {
                    FlowConditionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowConditionValue = table.Column<string>(nullable: false),
                    FlowLinkConditionId = table.Column<int>(nullable: false),
                    FlowConditionOperator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowConditions", x => x.FlowConditionId);
                    table.ForeignKey(
                        name: "FK_FlowConditions_FlowLinkConditions_FlowLinkConditionId",
                        column: x => x.FlowLinkConditionId,
                        principalTable: "FlowLinkConditions",
                        principalColumn: "FlowLinkConditionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 25, 21, 14, 54, 806, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 25, 21, 14, 54, 814, DateTimeKind.Local).AddTicks(5390));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 25, 21, 14, 54, 814, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.InsertData(
                table: "FlowConditions",
                columns: new[] { "FlowConditionId", "FlowConditionOperator", "FlowConditionValue", "FlowLinkConditionId" },
                values: new object[,]
                {
                    { 1, "None", "YES", 1 },
                    { 2, "None", "GOOD", 2 },
                    { 3, "None", "GREAT", 2 },
                    { 4, "None", "AMAZING", 2 },
                    { 5, "GreaterThan", "9000", 3 },
                    { 6, "LessThan", "10000", 3 },
                    { 7, "GreaterThanOrEqualTo", "2025-01-01", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlowConditions_FlowLinkConditionId",
                table: "FlowConditions",
                column: "FlowLinkConditionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowConditions");

            migrationBuilder.CreateTable(
                name: "FlowConditionValues",
                columns: table => new
                {
                    FlowConditionValueId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowConditionValueOperator = table.Column<string>(type: "text", nullable: false),
                    FlowConditionValueString = table.Column<string>(type: "text", nullable: false),
                    FlowLinkConditionId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowConditionValues", x => x.FlowConditionValueId);
                    table.ForeignKey(
                        name: "FK_FlowConditionValues_FlowLinkConditions_FlowLinkConditionId",
                        column: x => x.FlowLinkConditionId,
                        principalTable: "FlowLinkConditions",
                        principalColumn: "FlowLinkConditionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 25, 21, 5, 26, 713, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 25, 21, 5, 26, 721, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 25, 21, 5, 26, 721, DateTimeKind.Local).AddTicks(5480));

            migrationBuilder.InsertData(
                table: "FlowConditionValues",
                columns: new[] { "FlowConditionValueId", "FlowConditionValueOperator", "FlowConditionValueString", "FlowLinkConditionId" },
                values: new object[,]
                {
                    { 1, "None", "YES", 1 },
                    { 2, "None", "GOOD", 2 },
                    { 3, "None", "GREAT", 2 },
                    { 4, "None", "AMAZING", 2 },
                    { 5, "GreaterThan", "9000", 3 },
                    { 6, "LessThan", "10000", 3 },
                    { 7, "GreaterThanOrEqualTo", "2025-01-01", 4 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlowConditionValues_FlowLinkConditionId",
                table: "FlowConditionValues",
                column: "FlowLinkConditionId");
        }
    }
}
