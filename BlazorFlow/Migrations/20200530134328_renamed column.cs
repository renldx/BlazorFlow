using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorFlow.Migrations
{
    public partial class renamedcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
