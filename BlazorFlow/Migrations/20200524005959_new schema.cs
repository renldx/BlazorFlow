using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlazorFlow.Migrations
{
    public partial class newschema : Migration
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
                name: "FlowConditionValues",
                columns: table => new
                {
                    FlowConditionValueId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowConditionValueString = table.Column<string>(nullable: false),
                    FlowConditionId = table.Column<int>(nullable: false)
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
                    FlowNodeType = table.Column<string>(nullable: false),
                    FlowNodeEntity = table.Column<string>(nullable: false),
                    FlowQuestionId = table.Column<int>(nullable: false)
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
                name: "FlowAnswers",
                columns: table => new
                {
                    FlowAnswerId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowAnswerCode = table.Column<string>(nullable: false),
                    FlowAnswerValue = table.Column<string>(nullable: false),
                    FlowAnswerTextEn = table.Column<string>(nullable: false),
                    FlowAnswerTextFr = table.Column<string>(nullable: false),
                    FlowNodeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowAnswers", x => x.FlowAnswerId);
                    table.ForeignKey(
                        name: "FK_FlowAnswers_FlowNodes_FlowNodeId",
                        column: x => x.FlowNodeId,
                        principalTable: "FlowNodes",
                        principalColumn: "FlowNodeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlowLink",
                columns: table => new
                {
                    FlowLinkId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FlowLinkVersion = table.Column<double>(nullable: false),
                    FlowId = table.Column<int>(nullable: false),
                    FlowNodePreviousFlowNodeId = table.Column<int>(nullable: false),
                    FlowNodeNextFlowNodeId = table.Column<int>(nullable: false),
                    FlowConditionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlowLink", x => x.FlowLinkId);
                    table.ForeignKey(
                        name: "FK_FlowLink_FlowConditions_FlowConditionId",
                        column: x => x.FlowConditionId,
                        principalTable: "FlowConditions",
                        principalColumn: "FlowConditionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowLink_Flows_FlowId",
                        column: x => x.FlowId,
                        principalTable: "Flows",
                        principalColumn: "FlowId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowLink_FlowNodes_FlowNodeNextFlowNodeId",
                        column: x => x.FlowNodeNextFlowNodeId,
                        principalTable: "FlowNodes",
                        principalColumn: "FlowNodeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlowLink_FlowNodes_FlowNodePreviousFlowNodeId",
                        column: x => x.FlowNodePreviousFlowNodeId,
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

            migrationBuilder.CreateIndex(
                name: "IX_FlowAnswers_FlowNodeId",
                table: "FlowAnswers",
                column: "FlowNodeId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowConditionValues_FlowConditionId",
                table: "FlowConditionValues",
                column: "FlowConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowLink_FlowConditionId",
                table: "FlowLink",
                column: "FlowConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowLink_FlowId",
                table: "FlowLink",
                column: "FlowId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowLink_FlowNodeNextFlowNodeId",
                table: "FlowLink",
                column: "FlowNodeNextFlowNodeId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowLink_FlowNodePreviousFlowNodeId",
                table: "FlowLink",
                column: "FlowNodePreviousFlowNodeId");

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
                name: "FlowAnswers");

            migrationBuilder.DropTable(
                name: "FlowConditionValues");

            migrationBuilder.DropTable(
                name: "FlowLink");

            migrationBuilder.DropTable(
                name: "UserFlowAnswerValues");

            migrationBuilder.DropTable(
                name: "FlowConditions");

            migrationBuilder.DropTable(
                name: "UserFlowAnswers");

            migrationBuilder.DropTable(
                name: "FlowNodes");

            migrationBuilder.DropTable(
                name: "UserFlows");

            migrationBuilder.DropTable(
                name: "FlowQuestions");
        }
    }
}
