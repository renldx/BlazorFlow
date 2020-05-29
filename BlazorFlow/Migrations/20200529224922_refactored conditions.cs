using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorFlow.Migrations
{
    public partial class refactoredconditions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowConditions_FlowLinkConditions_FlowLinkConditionId",
                table: "FlowConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_FlowLinkConditions_FlowLinkConditionId",
                table: "FlowLinks");

            migrationBuilder.DropIndex(
                name: "IX_FlowLinks_FlowLinkConditionId",
                table: "FlowLinks");

            migrationBuilder.DropIndex(
                name: "IX_FlowConditions_FlowLinkConditionId",
                table: "FlowConditions");

            migrationBuilder.DropColumn(
                name: "FlowLinkConditionId",
                table: "FlowLinks");

            migrationBuilder.DropColumn(
                name: "FlowLinkConditionId",
                table: "FlowConditions");

            migrationBuilder.AddColumn<int>(
                name: "FlowConditionId",
                table: "FlowLinkConditions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlowLinkId",
                table: "FlowLinkConditions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FlowConditionType",
                table: "FlowConditions",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 29, 18, 49, 21, 927, DateTimeKind.Local).AddTicks(4560));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 29, 18, 49, 21, 938, DateTimeKind.Local).AddTicks(8000));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 29, 18, 49, 21, 938, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 1,
                column: "FlowConditionType",
                value: "radio");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 2,
                column: "FlowConditionType",
                value: "checkbox");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 3,
                column: "FlowConditionType",
                value: "checkbox");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 4,
                column: "FlowConditionType",
                value: "checkbox");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 5,
                column: "FlowConditionType",
                value: "number");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 6,
                column: "FlowConditionType",
                value: "number");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 7,
                column: "FlowConditionType",
                value: "datetime");

            migrationBuilder.UpdateData(
                table: "FlowLinkConditions",
                keyColumn: "FlowLinkConditionId",
                keyValue: 1,
                columns: new[] { "FlowConditionId", "FlowLinkId" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "FlowLinkConditions",
                keyColumn: "FlowLinkConditionId",
                keyValue: 2,
                columns: new[] { "FlowConditionId", "FlowLinkId" },
                values: new object[] { 2, 5 });

            migrationBuilder.UpdateData(
                table: "FlowLinkConditions",
                keyColumn: "FlowLinkConditionId",
                keyValue: 3,
                columns: new[] { "FlowConditionId", "FlowLinkId" },
                values: new object[] { 3, 5 });

            migrationBuilder.UpdateData(
                table: "FlowLinkConditions",
                keyColumn: "FlowLinkConditionId",
                keyValue: 4,
                columns: new[] { "FlowConditionId", "FlowLinkId" },
                values: new object[] { 4, 5 });

            migrationBuilder.InsertData(
                table: "FlowLinkConditions",
                columns: new[] { "FlowLinkConditionId", "FlowConditionId", "FlowLinkId" },
                values: new object[,]
                {
                    { 7, 7, 9 },
                    { 6, 6, 7 },
                    { 5, 5, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlowLinkConditions_FlowConditionId",
                table: "FlowLinkConditions",
                column: "FlowConditionId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FlowLinkConditions_FlowLinkId",
                table: "FlowLinkConditions",
                column: "FlowLinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinkConditions_FlowConditions_FlowConditionId",
                table: "FlowLinkConditions",
                column: "FlowConditionId",
                principalTable: "FlowConditions",
                principalColumn: "FlowConditionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinkConditions_FlowLinks_FlowLinkId",
                table: "FlowLinkConditions",
                column: "FlowLinkId",
                principalTable: "FlowLinks",
                principalColumn: "FlowLinkId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinkConditions_FlowConditions_FlowConditionId",
                table: "FlowLinkConditions");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinkConditions_FlowLinks_FlowLinkId",
                table: "FlowLinkConditions");

            migrationBuilder.DropIndex(
                name: "IX_FlowLinkConditions_FlowConditionId",
                table: "FlowLinkConditions");

            migrationBuilder.DropIndex(
                name: "IX_FlowLinkConditions_FlowLinkId",
                table: "FlowLinkConditions");

            migrationBuilder.DeleteData(
                table: "FlowLinkConditions",
                keyColumn: "FlowLinkConditionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FlowLinkConditions",
                keyColumn: "FlowLinkConditionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FlowLinkConditions",
                keyColumn: "FlowLinkConditionId",
                keyValue: 7);

            migrationBuilder.DropColumn(
                name: "FlowConditionId",
                table: "FlowLinkConditions");

            migrationBuilder.DropColumn(
                name: "FlowLinkId",
                table: "FlowLinkConditions");

            migrationBuilder.DropColumn(
                name: "FlowConditionType",
                table: "FlowConditions");

            migrationBuilder.AddColumn<int>(
                name: "FlowLinkConditionId",
                table: "FlowLinks",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlowLinkConditionId",
                table: "FlowConditions",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 1,
                column: "FlowLinkConditionId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 2,
                column: "FlowLinkConditionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 3,
                column: "FlowLinkConditionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 4,
                column: "FlowLinkConditionId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 5,
                column: "FlowLinkConditionId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 6,
                column: "FlowLinkConditionId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
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
                name: "IX_FlowConditions_FlowLinkConditionId",
                table: "FlowConditions",
                column: "FlowLinkConditionId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowConditions_FlowLinkConditions_FlowLinkConditionId",
                table: "FlowConditions",
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
    }
}
