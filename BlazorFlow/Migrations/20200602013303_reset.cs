using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlazorFlow.Migrations
{
    public partial class reset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "FlowAnswers",
                columns: table => new
                {
                    FlowAnswerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowAnswerCode = table.Column<string>(nullable: false),
                    FlowAnswerValue = table.Column<string>(nullable: false),
                    FlowAnswerTextEn = table.Column<string>(nullable: false),
                    FlowAnswerTextFr = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowAnswers", x => x.FlowAnswerId);
                });

            migrationBuilder.CreateTable(
                name: "FlowConditions",
                columns: table => new
                {
                    FlowConditionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowConditionValue = table.Column<string>(nullable: false),
                    FlowConditionOperator = table.Column<string>(nullable: false),
                    FlowConditionType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowConditions", x => x.FlowConditionId);
                });

            migrationBuilder.CreateTable(
                name: "FlowQuestions",
                columns: table => new
                {
                    FlowQuestionId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowQuestionCode = table.Column<string>(nullable: false),
                    FlowQuestionTextEn = table.Column<string>(nullable: false),
                    FlowQuestionTextFr = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowQuestions", x => x.FlowQuestionId);
                });

            migrationBuilder.CreateTable(
                name: "Flows",
                columns: table => new
                {
                    FlowId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowVersion = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flows", x => x.FlowId);
                });

            migrationBuilder.CreateTable(
                name: "FlowNodes",
                columns: table => new
                {
                    FlowNodeId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowNodeVersion = table.Column<double>(nullable: false),
                    FlowId = table.Column<int>(nullable: false),
                    FlowQuestionId = table.Column<int>(nullable: false),
                    FlowNodeType = table.Column<string>(nullable: false),
                    FlowNodeEntity = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowNodes", x => x.FlowNodeId);
                    table.ForeignKey(
                        name: "FK_FlowNodes_Flows_FlowId",
                        column: x => x.FlowId,
                        principalTable: "Flows",
                        principalColumn: "FlowId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowNodes_FlowQuestions_FlowQuestionId",
                        column: x => x.FlowQuestionId,
                        principalTable: "FlowQuestions",
                        principalColumn: "FlowQuestionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFlows",
                columns: table => new
                {
                    UserFlowId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<int>(nullable: false),
                    FlowId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFlows", x => x.UserFlowId);
                    table.ForeignKey(
                        name: "FK_UserFlows_Flows_FlowId",
                        column: x => x.FlowId,
                        principalTable: "Flows",
                        principalColumn: "FlowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlowLinks",
                columns: table => new
                {
                    FlowLinkId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowLinkVersion = table.Column<double>(nullable: false),
                    FlowId = table.Column<int>(nullable: false),
                    FlowNodePreviousId = table.Column<int>(nullable: false),
                    FlowNodeNextId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowLinks", x => x.FlowLinkId);
                    table.ForeignKey(
                        name: "FK_FlowLinks_Flows_FlowId",
                        column: x => x.FlowId,
                        principalTable: "Flows",
                        principalColumn: "FlowId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowLinks_FlowNodes_FlowNodeNextId",
                        column: x => x.FlowNodeNextId,
                        principalTable: "FlowNodes",
                        principalColumn: "FlowNodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowLinks_FlowNodes_FlowNodePreviousId",
                        column: x => x.FlowNodePreviousId,
                        principalTable: "FlowNodes",
                        principalColumn: "FlowNodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlowNodeAnswers",
                columns: table => new
                {
                    FlowNodeId = table.Column<int>(nullable: false),
                    FlowAnswerId = table.Column<int>(nullable: false),
                    FlowNodeAnswerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowNodeAnswers", x => new { x.FlowNodeId, x.FlowAnswerId });
                    table.ForeignKey(
                        name: "FK_FlowNodeAnswers_FlowAnswers_FlowAnswerId",
                        column: x => x.FlowAnswerId,
                        principalTable: "FlowAnswers",
                        principalColumn: "FlowAnswerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowNodeAnswers_FlowNodes_FlowNodeId",
                        column: x => x.FlowNodeId,
                        principalTable: "FlowNodes",
                        principalColumn: "FlowNodeId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "FlowLinkConditions",
                columns: table => new
                {
                    FlowLinkId = table.Column<int>(nullable: false),
                    FlowConditionId = table.Column<int>(nullable: false),
                    FlowLinkConditionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowLinkConditions", x => new { x.FlowLinkId, x.FlowConditionId });
                    table.ForeignKey(
                        name: "FK_FlowLinkConditions_FlowConditions_FlowConditionId",
                        column: x => x.FlowConditionId,
                        principalTable: "FlowConditions",
                        principalColumn: "FlowConditionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowLinkConditions_FlowLinks_FlowLinkId",
                        column: x => x.FlowLinkId,
                        principalTable: "FlowLinks",
                        principalColumn: "FlowLinkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFlowAnswers",
                columns: table => new
                {
                    UserFlowAnswerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserFlowAnswerValue = table.Column<string>(nullable: false),
                    UserFlowAnswerType = table.Column<string>(nullable: false),
                    UserFlowNodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFlowAnswers", x => x.UserFlowAnswerId);
                    table.ForeignKey(
                        name: "FK_UserFlowAnswers_UserFlowNodes_UserFlowNodeId",
                        column: x => x.UserFlowNodeId,
                        principalTable: "UserFlowNodes",
                        principalColumn: "UserFlowNodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 1, 21, 33, 2, 496, DateTimeKind.Local).AddTicks(7690), "John", "Doe" },
                    { 2, new DateTime(2020, 6, 1, 21, 33, 2, 504, DateTimeKind.Local).AddTicks(8860), "Eddie", "Murphy" },
                    { 3, new DateTime(2020, 6, 1, 21, 33, 2, 504, DateTimeKind.Local).AddTicks(8910), "Jim", "Carrey" }
                });

            migrationBuilder.InsertData(
                table: "FlowAnswers",
                columns: new[] { "FlowAnswerId", "FlowAnswerCode", "FlowAnswerTextEn", "FlowAnswerTextFr", "FlowAnswerValue" },
                values: new object[,]
                {
                    { 1, "YES", "Yes", "Oui", "YES" },
                    { 2, "NO", "No", "Non", "NO" },
                    { 3, "GOOD", "Good", "Bon", "GOOD" },
                    { 4, "GREAT", "Great", "Génial", "GREAT" },
                    { 5, "AMAZING", "Amazing", "Incroyable", "AMAZING" },
                    { 6, "BAD", "Bad", "Mauv", "BAD" }
                });

            migrationBuilder.InsertData(
                table: "FlowConditions",
                columns: new[] { "FlowConditionId", "FlowConditionOperator", "FlowConditionType", "FlowConditionValue" },
                values: new object[,]
                {
                    { 7, "GreaterThanOrEqualTo", "DateTime", "2025-01-01" },
                    { 6, "LessThan", "Number", "10000" },
                    { 4, "EqualTo", "Checkbox", "AMAZING" },
                    { 5, "GreaterThan", "Number", "9000" },
                    { 2, "EqualTo", "Checkbox", "GOOD" },
                    { 1, "EqualTo", "Radio", "YES" },
                    { 3, "EqualTo", "Checkbox", "GREAT" }
                });

            migrationBuilder.InsertData(
                table: "FlowQuestions",
                columns: new[] { "FlowQuestionId", "FlowQuestionCode", "FlowQuestionTextEn", "FlowQuestionTextFr" },
                values: new object[,]
                {
                    { 11, "TEXT", "This is a text input box.", "" },
                    { 10, "BADDATE", "Invalid date, try again.", "" },
                    { 9, "DATE", "This is a date check, which needs to be in the future from now.", "" },
                    { 8, "BADMULTI", "Invalid selections, try again.", "" },
                    { 7, "MULTI", "This is a multi-choice question, in the form of checkboxes.", "" },
                    { 6, "BADNUMBER", "Invalid number, try again.", "" },
                    { 5, "NUMBER", "This is a number range check, which needs to be in between 9000 and 10000.", "" },
                    { 3, "SINGLESELECT", "This is a single-choice question, in the form of a drop-down list, representing a lookup to an associated entity.", "" },
                    { 2, "SINGLERADIO", "This is a single-choice question, in the form of radio buttons, representing primitive values.", "" },
                    { 1, "START", "Welcome! You're starting a new application.", "" },
                    { 12, "TEXTAREA", "This is a paragraph input box.", "" },
                    { 4, "BADSINGLE", "Invalid selection, try again.", "" },
                    { 13, "END", "You've completed the application. Thanks!", "" }
                });

            migrationBuilder.InsertData(
                table: "Flows",
                columns: new[] { "FlowId", "FlowVersion" },
                values: new object[] { 1, 1.0 });

            migrationBuilder.InsertData(
                table: "FlowNodes",
                columns: new[] { "FlowNodeId", "FlowId", "FlowNodeEntity", "FlowNodeType", "FlowNodeVersion", "FlowQuestionId" },
                values: new object[,]
                {
                    { 1, 1, "None", "None", 1.0, 1 },
                    { 2, 1, "None", "Radio", 1.0, 2 },
                    { 3, 1, "Contact", "Select", 1.0, 3 },
                    { 4, 1, "None", "None", 1.0, 4 },
                    { 5, 1, "None", "Number", 1.0, 5 },
                    { 6, 1, "None", "None", 1.0, 6 },
                    { 7, 1, "None", "Checkbox", 1.0, 7 },
                    { 8, 1, "None", "None", 1.0, 8 },
                    { 9, 1, "None", "DateTime", 1.0, 9 },
                    { 10, 1, "None", "None", 1.0, 10 },
                    { 11, 1, "None", "Text", 1.0, 11 },
                    { 12, 1, "None", "TextArea", 1.0, 12 },
                    { 13, 1, "None", "None", 1.0, 13 }
                });

            migrationBuilder.InsertData(
                table: "FlowLinks",
                columns: new[] { "FlowLinkId", "FlowId", "FlowLinkVersion", "FlowNodeNextId", "FlowNodePreviousId" },
                values: new object[,]
                {
                    { 1, 1, 1.0, 2, 1 },
                    { 9, 1, 1.0, 11, 9 },
                    { 10, 1, 1.0, 10, 9 },
                    { 7, 1, 1.0, 9, 7 },
                    { 8, 1, 1.0, 8, 7 },
                    { 11, 1, 1.0, 12, 11 },
                    { 5, 1, 1.0, 7, 5 },
                    { 12, 1, 1.0, 13, 12 },
                    { 4, 1, 1.0, 5, 3 },
                    { 3, 1, 1.0, 4, 2 },
                    { 2, 1, 1.0, 3, 2 },
                    { 6, 1, 1.0, 6, 5 }
                });

            migrationBuilder.InsertData(
                table: "FlowNodeAnswers",
                columns: new[] { "FlowNodeId", "FlowAnswerId", "FlowNodeAnswerId" },
                values: new object[,]
                {
                    { 7, 4, 4 },
                    { 7, 5, 5 },
                    { 7, 6, 6 },
                    { 2, 2, 2 },
                    { 2, 1, 1 },
                    { 7, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "FlowLinkConditions",
                columns: new[] { "FlowLinkId", "FlowConditionId", "FlowLinkConditionId" },
                values: new object[,]
                {
                    { 2, 1, 1 },
                    { 5, 5, 2 },
                    { 5, 6, 3 },
                    { 7, 2, 4 },
                    { 7, 3, 5 },
                    { 7, 4, 6 },
                    { 9, 7, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlowLinkConditions_FlowConditionId",
                table: "FlowLinkConditions",
                column: "FlowConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowLinks_FlowId",
                table: "FlowLinks",
                column: "FlowId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowLinks_FlowNodeNextId",
                table: "FlowLinks",
                column: "FlowNodeNextId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowLinks_FlowNodePreviousId",
                table: "FlowLinks",
                column: "FlowNodePreviousId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowNodeAnswers_FlowAnswerId",
                table: "FlowNodeAnswers",
                column: "FlowAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowNodes_FlowId",
                table: "FlowNodes",
                column: "FlowId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowNodes_FlowQuestionId",
                table: "FlowNodes",
                column: "FlowQuestionId");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserFlows_FlowId",
                table: "UserFlows",
                column: "FlowId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "FlowLinkConditions");

            migrationBuilder.DropTable(
                name: "FlowNodeAnswers");

            migrationBuilder.DropTable(
                name: "UserFlowAnswers");

            migrationBuilder.DropTable(
                name: "FlowConditions");

            migrationBuilder.DropTable(
                name: "FlowLinks");

            migrationBuilder.DropTable(
                name: "FlowAnswers");

            migrationBuilder.DropTable(
                name: "UserFlowNodes");

            migrationBuilder.DropTable(
                name: "FlowNodes");

            migrationBuilder.DropTable(
                name: "UserFlows");

            migrationBuilder.DropTable(
                name: "FlowQuestions");

            migrationBuilder.DropTable(
                name: "Flows");
        }
    }
}
