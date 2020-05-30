using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorFlow.Migrations
{
    public partial class addedoperationsseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 30, 10, 40, 26, 815, DateTimeKind.Local).AddTicks(4650));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 30, 10, 40, 26, 823, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 30, 10, 40, 26, 823, DateTimeKind.Local).AddTicks(6330));

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 1,
                column: "FlowConditionOperator",
                value: "EqualTo");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 2,
                column: "FlowConditionOperator",
                value: "EqualTo");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 3,
                column: "FlowConditionOperator",
                value: "EqualTo");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 4,
                column: "FlowConditionOperator",
                value: "EqualTo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 30, 9, 43, 27, 568, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 30, 9, 43, 27, 576, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 30, 9, 43, 27, 576, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 1,
                column: "FlowConditionOperator",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 2,
                column: "FlowConditionOperator",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 3,
                column: "FlowConditionOperator",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 4,
                column: "FlowConditionOperator",
                value: "None");
        }
    }
}
