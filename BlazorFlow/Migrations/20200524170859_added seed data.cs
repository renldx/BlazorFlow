using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorFlow.Migrations
{
    public partial class addedseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_FlowNodes_FlowNodeNextFlowNodeId",
                table: "FlowLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_FlowNodes_FlowNodePreviousFlowNodeId",
                table: "FlowLinks");

            migrationBuilder.DropIndex(
                name: "IX_FlowLinks_FlowNodeNextFlowNodeId",
                table: "FlowLinks");

            migrationBuilder.DropIndex(
                name: "IX_FlowLinks_FlowNodePreviousFlowNodeId",
                table: "FlowLinks");

            migrationBuilder.DropColumn(
                name: "FlowNodeNextFlowNodeId",
                table: "FlowLinks");

            migrationBuilder.DropColumn(
                name: "FlowNodePreviousFlowNodeId",
                table: "FlowLinks");

            migrationBuilder.AddColumn<int>(
                name: "FlowNodeNextId",
                table: "FlowLinks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlowNodePreviousId",
                table: "FlowLinks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FlowConditionValueOperator",
                table: "FlowConditionValues",
                nullable: false,
                defaultValue: "");

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
                    1,
                    2,
                    3,
                    4
                });

            migrationBuilder.InsertData(
                table: "FlowQuestions",
                columns: new[] { "FlowQuestionId", "FlowQuestionCode", "FlowQuestionTextEn", "FlowQuestionTextFr" },
                values: new object[,]
                {
                    { 1, "START", "Welcome! You're starting a new application.", "" },
                    { 11, "TEXT", "This is a text input box.", "" },
                    { 10, "BADDATE", "Invalid date, try again.", "" },
                    { 9, "DATE", "This is a date check, which needs to be in the future from now.", "" },
                    { 8, "BADMULTI", "Invalid selections, try again.", "" },
                    { 7, "MULTI", "This is a multi-choice question, in the form of checkboxes.", "" },
                    { 13, "END", "You've completed the application. Thanks!", "" },
                    { 5, "NUMBER", "This is a number range check, which needs to be in between 9000 and 10000.", "" },
                    { 4, "BADSINGLE", "Invalid selection, try again.", "" },
                    { 3, "SINGLESELECT", "This is a single-choice question, in the form of a drop-down list, representing a lookup to an associated entity.", "" },
                    { 2, "SINGLERADIO", "This is a single-choice question, in the form of radio buttons, representing primitive values.", "" },
                    { 12, "TEXTAREA", "This is a paragraph input box.", "" },
                    { 6, "BADNUMBER", "Invalid number, try again.", "" }
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
                name: "IX_FlowLinks_FlowNodeNextId",
                table: "FlowLinks",
                column: "FlowNodeNextId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowLinks_FlowNodePreviousId",
                table: "FlowLinks",
                column: "FlowNodePreviousId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinks_FlowNodes_FlowNodeNextId",
                table: "FlowLinks",
                column: "FlowNodeNextId",
                principalTable: "FlowNodes",
                principalColumn: "FlowNodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinks_FlowNodes_FlowNodePreviousId",
                table: "FlowLinks",
                column: "FlowNodePreviousId",
                principalTable: "FlowNodes",
                principalColumn: "FlowNodeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_FlowNodes_FlowNodeNextId",
                table: "FlowLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_FlowNodes_FlowNodePreviousId",
                table: "FlowLinks");

            migrationBuilder.DropIndex(
                name: "IX_FlowLinks_FlowNodeNextId",
                table: "FlowLinks");

            migrationBuilder.DropIndex(
                name: "IX_FlowLinks_FlowNodePreviousId",
                table: "FlowLinks");

            migrationBuilder.DeleteData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FlowConditionValues",
                keyColumn: "FlowConditionValueId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FlowLinks",
                keyColumn: "FlowLinkId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FlowNodeAnswers",
                keyColumn: "FlowNodeAnswerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FlowNodeAnswers",
                keyColumn: "FlowNodeAnswerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlowNodeAnswers",
                keyColumn: "FlowNodeAnswerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FlowNodeAnswers",
                keyColumn: "FlowNodeAnswerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FlowNodeAnswers",
                keyColumn: "FlowNodeAnswerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FlowNodeAnswers",
                keyColumn: "FlowNodeAnswerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FlowAnswers",
                keyColumn: "FlowAnswerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FlowAnswers",
                keyColumn: "FlowAnswerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlowAnswers",
                keyColumn: "FlowAnswerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FlowAnswers",
                keyColumn: "FlowAnswerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FlowAnswers",
                keyColumn: "FlowAnswerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FlowAnswers",
                keyColumn: "FlowAnswerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FlowConditions",
                keyColumn: "FlowConditionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FlowNodes",
                keyColumn: "FlowNodeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "FlowQuestions",
                keyColumn: "FlowQuestionId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Flows",
                keyColumn: "FlowId",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "FlowNodeNextId",
                table: "FlowLinks");

            migrationBuilder.DropColumn(
                name: "FlowNodePreviousId",
                table: "FlowLinks");

            migrationBuilder.DropColumn(
                name: "FlowConditionValueOperator",
                table: "FlowConditionValues");

            migrationBuilder.AddColumn<int>(
                name: "FlowNodeNextFlowNodeId",
                table: "FlowLinks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FlowNodePreviousFlowNodeId",
                table: "FlowLinks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FlowLinks_FlowNodeNextFlowNodeId",
                table: "FlowLinks",
                column: "FlowNodeNextFlowNodeId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowLinks_FlowNodePreviousFlowNodeId",
                table: "FlowLinks",
                column: "FlowNodePreviousFlowNodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinks_FlowNodes_FlowNodeNextFlowNodeId",
                table: "FlowLinks",
                column: "FlowNodeNextFlowNodeId",
                principalTable: "FlowNodes",
                principalColumn: "FlowNodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinks_FlowNodes_FlowNodePreviousFlowNodeId",
                table: "FlowLinks",
                column: "FlowNodePreviousFlowNodeId",
                principalTable: "FlowNodes",
                principalColumn: "FlowNodeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
