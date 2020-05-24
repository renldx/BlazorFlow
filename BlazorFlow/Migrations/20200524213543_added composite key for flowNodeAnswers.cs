using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlazorFlow.Migrations
{
    public partial class addedcompositekeyforflowNodeAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FlowNodeAnswers",
                table: "FlowNodeAnswers");

            migrationBuilder.DropIndex(
                name: "IX_FlowNodeAnswers_FlowNodeId",
                table: "FlowNodeAnswers");

            migrationBuilder.AlterColumn<int>(
                name: "FlowNodeAnswerId",
                table: "FlowNodeAnswers",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlowNodeAnswers",
                table: "FlowNodeAnswers",
                columns: new[] { "FlowNodeId", "FlowAnswerId" });

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 24, 17, 35, 42, 758, DateTimeKind.Local).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 24, 17, 35, 42, 766, DateTimeKind.Local).AddTicks(9390));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 24, 17, 35, 42, 766, DateTimeKind.Local).AddTicks(9440));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FlowNodeAnswers",
                table: "FlowNodeAnswers");

            migrationBuilder.AlterColumn<int>(
                name: "FlowNodeAnswerId",
                table: "FlowNodeAnswers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlowNodeAnswers",
                table: "FlowNodeAnswers",
                column: "FlowNodeAnswerId");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 24, 15, 29, 37, 456, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 24, 15, 29, 37, 464, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 24, 15, 29, 37, 464, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.CreateIndex(
                name: "IX_FlowNodeAnswers_FlowNodeId",
                table: "FlowNodeAnswers",
                column: "FlowNodeId");
        }
    }
}
