using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlazorFlow.Migrations
{
    public partial class refactoredflowconditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowConditionValues_FlowConditions_FlowConditionId",
                table: "FlowConditionValues");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_FlowConditions_FlowConditionId",
                table: "FlowLinks");

            migrationBuilder.DropTable(
                name: "FlowConditions");

            migrationBuilder.DropIndex(
                name: "IX_FlowLinks_FlowConditionId",
                table: "FlowLinks");

            migrationBuilder.DropIndex(
                name: "IX_FlowConditionValues_FlowConditionId",
                table: "FlowConditionValues");

            migrationBuilder.DropColumn(
                name: "FlowConditionId",
                table: "FlowLinks");

            migrationBuilder.DropColumn(
                name: "FlowConditionId",
                table: "FlowConditionValues");

            migrationBuilder.AddColumn<int>(
                name: "FlowLinkConditionId",
                table: "FlowLinks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlowLinkConditionId",
                table: "FlowConditionValues",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FlowLinkConditions",
                columns: table => new
                {
                    FlowLinkConditionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowLinkConditions", x => x.FlowLinkConditionId);
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
                table: "FlowLinkConditions",
                column: "FlowLinkConditionId",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4
                });

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 1,
                column: "FlowLinkConditionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 2,
                column: "FlowLinkConditionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 3,
                column: "FlowLinkConditionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 4,
                column: "FlowLinkConditionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 5,
                column: "FlowLinkConditionId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 6,
                column: "FlowLinkConditionId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 7,
                column: "FlowLinkConditionId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 2,
                column: "FlowLinkConditionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 5,
                column: "FlowLinkConditionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 7,
                column: "FlowLinkConditionId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 9,
                column: "FlowLinkConditionId",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_FlowLinks_FlowLinkConditionId",
                table: "FlowLinks",
                column: "FlowLinkConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowConditionValues_FlowLinkConditionId",
                table: "FlowConditionValues",
                column: "FlowLinkConditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowConditionValues_FlowLinkConditions_FlowLinkConditionId",
                table: "FlowConditionValues",
                column: "FlowLinkConditionId",
                principalTable: "FlowLinkConditions",
                principalColumn: "FlowLinkConditionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinks_FlowLinkConditions_FlowLinkConditionId",
                table: "FlowLinks",
                column: "FlowLinkConditionId",
                principalTable: "FlowLinkConditions",
                principalColumn: "FlowLinkConditionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowConditionValues_FlowLinkConditions_FlowLinkConditionId",
                table: "FlowConditionValues");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_FlowLinkConditions_FlowLinkConditionId",
                table: "FlowLinks");

            migrationBuilder.DropTable(
                name: "FlowLinkConditions");

            migrationBuilder.DropIndex(
                name: "IX_FlowLinks_FlowLinkConditionId",
                table: "FlowLinks");

            migrationBuilder.DropIndex(
                name: "IX_FlowConditionValues_FlowLinkConditionId",
                table: "FlowConditionValues");

            migrationBuilder.DropColumn(
                name: "FlowLinkConditionId",
                table: "FlowLinks");

            migrationBuilder.DropColumn(
                name: "FlowLinkConditionId",
                table: "FlowConditionValues");

            migrationBuilder.AddColumn<int>(
                name: "FlowConditionId",
                table: "FlowLinks",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlowConditionId",
                table: "FlowConditionValues",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FlowConditions",
                columns: table => new
                {
                    FlowConditionId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowConditions", x => x.FlowConditionId);
                });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 25, 20, 47, 57, 948, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 25, 20, 47, 57, 956, DateTimeKind.Local).AddTicks(7330));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 25, 20, 47, 57, 956, DateTimeKind.Local).AddTicks(7380));

            migrationBuilder.InsertData(
                table: "FlowConditions",
                column: "FlowConditionId",
                values: new object[]
                {
                    1,
                    2,
                    3,
                    4
                });

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 1,
                column: "FlowConditionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 2,
                column: "FlowConditionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 3,
                column: "FlowConditionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 4,
                column: "FlowConditionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 5,
                column: "FlowConditionId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 6,
                column: "FlowConditionId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 7,
                column: "FlowConditionId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 2,
                column: "FlowConditionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 5,
                column: "FlowConditionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 7,
                column: "FlowConditionId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 9,
                column: "FlowConditionId",
                value: 4);

            migrationBuilder.CreateIndex(
                name: "IX_FlowLinks_FlowConditionId",
                table: "FlowLinks",
                column: "FlowConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowConditionValues_FlowConditionId",
                table: "FlowConditionValues",
                column: "FlowConditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowConditionValues_FlowConditions_FlowConditionId",
                table: "FlowConditionValues",
                column: "FlowConditionId",
                principalTable: "FlowConditions",
                principalColumn: "FlowConditionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinks_FlowConditions_FlowConditionId",
                table: "FlowLinks",
                column: "FlowConditionId",
                principalTable: "FlowConditions",
                principalColumn: "FlowConditionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
