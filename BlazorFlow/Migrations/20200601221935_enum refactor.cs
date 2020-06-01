using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorFlow.Migrations
{
    public partial class enumrefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 6, 1, 18, 19, 34, 914, DateTimeKind.Local).AddTicks(3050));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 6, 1, 18, 19, 34, 922, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 6, 1, 18, 19, 34, 922, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 1,
                column: "FlowNodeEntity",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 2,
                column: "FlowNodeEntity",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 3,
                column: "FlowNodeEntity",
                value: "Contact");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 4,
                column: "FlowNodeEntity",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 5,
                column: "FlowNodeEntity",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 6,
                column: "FlowNodeEntity",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 7,
                column: "FlowNodeEntity",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 8,
                column: "FlowNodeEntity",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 9,
                column: "FlowNodeEntity",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 10,
                column: "FlowNodeEntity",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 11,
                column: "FlowNodeEntity",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 12,
                column: "FlowNodeEntity",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 13,
                column: "FlowNodeEntity",
                value: "None");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 31, 18, 48, 44, 776, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 31, 18, 48, 44, 784, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 31, 18, 48, 44, 784, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 1,
                column: "FlowNodeEntity",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 2,
                column: "FlowNodeEntity",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 3,
                column: "FlowNodeEntity",
                value: "contact");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 4,
                column: "FlowNodeEntity",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 5,
                column: "FlowNodeEntity",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 6,
                column: "FlowNodeEntity",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 7,
                column: "FlowNodeEntity",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 8,
                column: "FlowNodeEntity",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 9,
                column: "FlowNodeEntity",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 10,
                column: "FlowNodeEntity",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 11,
                column: "FlowNodeEntity",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 12,
                column: "FlowNodeEntity",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 13,
                column: "FlowNodeEntity",
                value: "none");
        }
    }
}
