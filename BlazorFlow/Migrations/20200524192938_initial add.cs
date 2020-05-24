using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlazorFlow.Migrations
{
    public partial class initialadd : Migration
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
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
                name: "FlowConditionValues",
                columns: table => new
                {
                    FlowConditionValueId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowConditionValueString = table.Column<string>(nullable: false),
                    FlowConditionId = table.Column<int>(nullable: false),
                    FlowConditionValueOperator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowConditionValues", x => x.FlowConditionValueId);
                    table.ForeignKey(
                        name: "FK_FlowConditionValues_FlowConditions_FlowConditionId",
                        column: x => x.FlowConditionId,
                        principalTable: "FlowConditions",
                        principalColumn: "FlowConditionId",
                        onDelete: ReferentialAction.Cascade);
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
                    FlowNodeNextId = table.Column<int>(nullable: false),
                    FlowConditionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowLinks", x => x.FlowLinkId);
                    table.ForeignKey(
                        name: "FK_FlowLinks_FlowConditions_FlowConditionId",
                        column: x => x.FlowConditionId,
                        principalTable: "FlowConditions",
                        principalColumn: "FlowConditionId",
                        onDelete: ReferentialAction.Restrict);
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
                    FlowNodeAnswerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowNodeId = table.Column<int>(nullable: false),
                    FlowAnswerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowNodeAnswers", x => x.FlowNodeAnswerId);
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
                name: "UserFlowAnswers",
                columns: table => new
                {
                    UserFlowAnswerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsStale = table.Column<bool>(nullable: false),
                    UserFlowId = table.Column<int>(nullable: false),
                    FlowNodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFlowAnswers", x => x.UserFlowAnswerId);
                    table.ForeignKey(
                        name: "FK_UserFlowAnswers_FlowNodes_FlowNodeId",
                        column: x => x.FlowNodeId,
                        principalTable: "FlowNodes",
                        principalColumn: "FlowNodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserFlowAnswers_UserFlows_UserFlowId",
                        column: x => x.UserFlowId,
                        principalTable: "UserFlows",
                        principalColumn: "UserFlowId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFlowAnswerValues",
                columns: table => new
                {
                    UserFlowAnswerValueId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserFlowAnswerValueString = table.Column<string>(nullable: false),
                    UserFlowAnswerId = table.Column<int>(nullable: false)
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

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "ContactId", "DateOfBirth", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 5, 24, 15, 29, 37, 456, DateTimeKind.Local).AddTicks(820), "John", "Doe" },
                    { 2, new DateTime(2020, 5, 24, 15, 29, 37, 464, DateTimeKind.Local).AddTicks(8670), "Eddie", "Murphy" },
                    { 3, new DateTime(2020, 5, 24, 15, 29, 37, 464, DateTimeKind.Local).AddTicks(8720), "Jim", "Carrey" }
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
                column: "FlowConditionId",
                values: new object[]
                {
                    3,
                    2,
                    4,
                    1
                });

            migrationBuilder.InsertData(
                table: "FlowQuestions",
                columns: new[] { "FlowQuestionId", "FlowQuestionCode", "FlowQuestionTextEn", "FlowQuestionTextFr" },
                values: new object[,]
                {
                    { 12, "TEXTAREA", "This is a paragraph input box.", "" },
                    { 1, "START", "Welcome! You're starting a new application.", "" },
                    { 2, "SINGLERADIO", "This is a single-choice question, in the form of radio buttons, representing primitive values.", "" },
                    { 3, "SINGLESELECT", "This is a single-choice question, in the form of a drop-down list, representing a lookup to an associated entity.", "" },
                    { 4, "BADSINGLE", "Invalid selection, try again.", "" },
                    { 5, "NUMBER", "This is a number range check, which needs to be in between 9000 and 10000.", "" },
                    { 6, "BADNUMBER", "Invalid number, try again.", "" },
                    { 7, "MULTI", "This is a multi-choice question, in the form of checkboxes.", "" },
                    { 8, "BADMULTI", "Invalid selections, try again.", "" },
                    { 9, "DATE", "This is a date check, which needs to be in the future from now.", "" },
                    { 10, "BADDATE", "Invalid date, try again.", "" },
                    { 11, "TEXT", "This is a text input box.", "" },
                    { 13, "END", "You've completed the application. Thanks!", "" }
                });

            migrationBuilder.InsertData(
                table: "Flows",
                columns: new[] { "FlowId", "FlowVersion" },
                values: new object[] { 1, 1.0 });

            migrationBuilder.InsertData(
                table: "FlowConditionValues",
                columns: new[] { "FlowConditionValueId", "FlowConditionId", "FlowConditionValueOperator", "FlowConditionValueString" },
                values: new object[,]
                {
                    { 1, 1, "None", "YES" },
                    { 2, 2, "None", "GOOD" },
                    { 3, 2, "None", "GREAT" },
                    { 4, 2, "None", "AMAZING" },
                    { 5, 3, "GreaterThan", "9000" },
                    { 6, 3, "LessThan", "10000" },
                    { 7, 4, "GreaterThanOrEqualTo", "2025-01-01" }
                });

            migrationBuilder.InsertData(
                table: "FlowNodes",
                columns: new[] { "FlowNodeId", "FlowId", "FlowNodeEntity", "FlowNodeType", "FlowNodeVersion", "FlowQuestionId" },
                values: new object[,]
                {
                    { 11, 1, "none", "text", 1.0, 11 },
                    { 10, 1, "none", "none", 1.0, 10 },
                    { 9, 1, "none", "datetime", 1.0, 9 },
                    { 8, 1, "none", "none", 1.0, 8 },
                    { 7, 1, "none", "checkbox", 1.0, 7 },
                    { 3, 1, "contact", "select", 1.0, 3 },
                    { 5, 1, "none", "number", 1.0, 5 },
                    { 4, 1, "none", "none", 1.0, 4 },
                    { 12, 1, "none", "textarea", 1.0, 12 },
                    { 2, 1, "none", "radio", 1.0, 2 },
                    { 1, 1, "none", "none", 1.0, 1 },
                    { 6, 1, "none", "none", 1.0, 6 },
                    { 13, 1, "none", "none", 1.0, 13 }
                });

            migrationBuilder.InsertData(
                table: "FlowLinks",
                columns: new[] { "FlowLinkId", "FlowConditionId", "FlowId", "FlowLinkVersion", "FlowNodeNextId", "FlowNodePreviousId" },
                values: new object[,]
                {
                    { 1, null, 1, 1.0, 2, 1 },
                    { 9, 4, 1, 1.0, 11, 9 },
                    { 10, null, 1, 1.0, 10, 9 },
                    { 7, 3, 1, 1.0, 9, 7 },
                    { 8, null, 1, 1.0, 8, 7 },
                    { 11, null, 1, 1.0, 12, 11 },
                    { 5, 2, 1, 1.0, 7, 5 },
                    { 12, null, 1, 1.0, 13, 12 },
                    { 4, null, 1, 1.0, 5, 3 },
                    { 3, null, 1, 1.0, 4, 2 },
                    { 2, 1, 1, 1.0, 3, 2 },
                    { 6, null, 1, 1.0, 6, 5 }
                });

            migrationBuilder.InsertData(
                table: "FlowNodeAnswers",
                columns: new[] { "FlowNodeAnswerId", "FlowAnswerId", "FlowNodeId" },
                values: new object[,]
                {
                    { 4, 4, 7 },
                    { 5, 5, 7 },
                    { 6, 6, 7 },
                    { 2, 2, 2 },
                    { 1, 1, 2 },
                    { 3, 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlowConditionValues_FlowConditionId",
                table: "FlowConditionValues",
                column: "FlowConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowLinks_FlowConditionId",
                table: "FlowLinks",
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
                name: "IX_FlowNodeAnswers_FlowNodeId",
                table: "FlowNodeAnswers",
                column: "FlowNodeId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowNodes_FlowId",
                table: "FlowNodes",
                column: "FlowId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowNodes_FlowQuestionId",
                table: "FlowNodes",
                column: "FlowQuestionId");

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
                name: "FlowConditionValues");

            migrationBuilder.DropTable(
                name: "FlowLinks");

            migrationBuilder.DropTable(
                name: "FlowNodeAnswers");

            migrationBuilder.DropTable(
                name: "UserFlowAnswerValues");

            migrationBuilder.DropTable(
                name: "FlowConditions");

            migrationBuilder.DropTable(
                name: "FlowAnswers");

            migrationBuilder.DropTable(
                name: "UserFlowAnswers");

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
