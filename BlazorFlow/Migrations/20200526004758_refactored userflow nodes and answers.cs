using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlazorFlow.Migrations
{
    public partial class refactoreduserflownodesandanswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFlowAnswers_FlowNodes_FlowNodeId",
                table: "UserFlowAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserFlowAnswers_UserFlows_UserFlowId",
                table: "UserFlowAnswers");

            migrationBuilder.DropTable(
                name: "UserFlowAnswerValues");

            migrationBuilder.DropIndex(
                name: "IX_UserFlowAnswers_FlowNodeId",
                table: "UserFlowAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserFlowAnswers_UserFlowId",
                table: "UserFlowAnswers");

            migrationBuilder.DropColumn(
                name: "FlowNodeId",
                table: "UserFlowAnswers");

            migrationBuilder.DropColumn(
                name: "IsStale",
                table: "UserFlowAnswers");

            migrationBuilder.DropColumn(
                name: "UserFlowId",
                table: "UserFlowAnswers");

            migrationBuilder.AddColumn<string>(
                name: "UserFlowAnswerValue",
                table: "UserFlowAnswers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UserFlowNodeId",
                table: "UserFlowAnswers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserFlowNodes",
                columns: table => new
                {
                    UserFlowNodeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsStale = table.Column<bool>(nullable: false),
                    UserFlowId = table.Column<int>(nullable: false),
                    FlowNodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFlowNodes", x => x.UserFlowNodeId);
                    table.ForeignKey(
                        name: "FK_UserFlowNodes_FlowNodes_FlowNodeId",
                        column: x => x.FlowNodeId,
                        principalTable: "FlowNodes",
                        principalColumn: "FlowNodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFlowNodes_UserFlows_UserFlowId",
                        column: x => x.UserFlowId,
                        principalTable: "UserFlows",
                        principalColumn: "UserFlowId",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_UserFlowAnswers_UserFlowNodeId",
                table: "UserFlowAnswers",
                column: "UserFlowNodeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFlowNodes_FlowNodeId",
                table: "UserFlowNodes",
                column: "FlowNodeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFlowNodes_UserFlowId",
                table: "UserFlowNodes",
                column: "UserFlowId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFlowAnswers_UserFlowNodes_UserFlowNodeId",
                table: "UserFlowAnswers",
                column: "UserFlowNodeId",
                principalTable: "UserFlowNodes",
                principalColumn: "UserFlowNodeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserFlowAnswers_UserFlowNodes_UserFlowNodeId",
                table: "UserFlowAnswers");

            migrationBuilder.DropTable(
                name: "UserFlowNodes");

            migrationBuilder.DropIndex(
                name: "IX_UserFlowAnswers_UserFlowNodeId",
                table: "UserFlowAnswers");

            migrationBuilder.DropColumn(
                name: "UserFlowAnswerValue",
                table: "UserFlowAnswers");

            migrationBuilder.DropColumn(
                name: "UserFlowNodeId",
                table: "UserFlowAnswers");

            migrationBuilder.AddColumn<int>(
                name: "FlowNodeId",
                table: "UserFlowAnswers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsStale",
                table: "UserFlowAnswers",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UserFlowId",
                table: "UserFlowAnswers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "UserFlowAnswerValues",
                columns: table => new
                {
                    UserFlowAnswerValueId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserFlowAnswerId = table.Column<int>(type: "integer", nullable: false),
                    UserFlowAnswerValueString = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFlowAnswerValues", x => x.UserFlowAnswerValueId);
                    table.ForeignKey(
                        name: "FK_UserFlowAnswerValues_UserFlowAnswers_UserFlowAnswerId",
                        column: x => x.UserFlowAnswerId,
                        principalTable: "UserFlowAnswers",
                        principalColumn: "UserFlowAnswerId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_UserFlowAnswers_FlowNodeId",
                table: "UserFlowAnswers",
                column: "FlowNodeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFlowAnswers_UserFlowId",
                table: "UserFlowAnswers",
                column: "UserFlowId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFlowAnswerValues_UserFlowAnswerId",
                table: "UserFlowAnswerValues",
                column: "UserFlowAnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserFlowAnswers_FlowNodes_FlowNodeId",
                table: "UserFlowAnswers",
                column: "FlowNodeId",
                principalTable: "FlowNodes",
                principalColumn: "FlowNodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserFlowAnswers_UserFlows_UserFlowId",
                table: "UserFlowAnswers",
                column: "UserFlowId",
                principalTable: "UserFlows",
                principalColumn: "UserFlowId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
