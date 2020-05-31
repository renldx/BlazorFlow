using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorFlow.Migrations
{
    public partial class addedvaluetypetouseranswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserFlowAnswerType",
                table: "UserFlowAnswers",
                nullable: false,
                defaultValue: "");

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
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 1,
                column: "FlowConditionType",
                value: "Radio");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 2,
                column: "FlowConditionType",
                value: "Checkbox");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 3,
                column: "FlowConditionType",
                value: "Checkbox");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 4,
                column: "FlowConditionType",
                value: "Checkbox");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 5,
                column: "FlowConditionType",
                value: "Number");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 6,
                column: "FlowConditionType",
                value: "Number");

            migrationBuilder.UpdateData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 7,
                column: "FlowConditionType",
                value: "DateTime");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 1,
                column: "FlowNodeType",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 2,
                column: "FlowNodeType",
                value: "Radio");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 3,
                column: "FlowNodeType",
                value: "Select");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 4,
                column: "FlowNodeType",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 5,
                column: "FlowNodeType",
                value: "Number");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 6,
                column: "FlowNodeType",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 7,
                column: "FlowNodeType",
                value: "Checkbox");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 8,
                column: "FlowNodeType",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 9,
                column: "FlowNodeType",
                value: "DateTime");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 10,
                column: "FlowNodeType",
                value: "None");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 11,
                column: "FlowNodeType",
                value: "Text");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 12,
                column: "FlowNodeType",
                value: "TextArea");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 13,
                column: "FlowNodeType",
                value: "None");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserFlowAnswerType",
                table: "UserFlowAnswers");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 30, 18, 56, 51, 363, DateTimeKind.Local).AddTicks(6630));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 30, 18, 56, 51, 372, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "ContactId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2020, 5, 30, 18, 56, 51, 372, DateTimeKind.Local).AddTicks(890));

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
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 1,
                column: "FlowNodeType",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 2,
                column: "FlowNodeType",
                value: "radio");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 3,
                column: "FlowNodeType",
                value: "select");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 4,
                column: "FlowNodeType",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 5,
                column: "FlowNodeType",
                value: "number");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 6,
                column: "FlowNodeType",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 7,
                column: "FlowNodeType",
                value: "checkbox");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 8,
                column: "FlowNodeType",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 9,
                column: "FlowNodeType",
                value: "datetime");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 10,
                column: "FlowNodeType",
                value: "none");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 11,
                column: "FlowNodeType",
                value: "text");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 12,
                column: "FlowNodeType",
                value: "textarea");

            migrationBuilder.UpdateData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 13,
                column: "FlowNodeType",
                value: "none");
        }
    }
}
