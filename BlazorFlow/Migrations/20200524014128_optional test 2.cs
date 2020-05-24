using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorFlow.Migrations
{
    public partial class optionaltest2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_FlowConditions_FlowConditionId",
                table: "FlowLinks");

            migrationBuilder.AlterColumn<int>(
                name: "FlowConditionId",
                table: "FlowLinks",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinks_FlowConditions_FlowConditionId",
                table: "FlowLinks",
                column: "FlowConditionId",
                principalTable: "FlowConditions",
                principalColumn: "FlowConditionId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_FlowConditions_FlowConditionId",
                table: "FlowLinks");

            migrationBuilder.AlterColumn<int>(
                name: "FlowConditionId",
                table: "FlowLinks",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinks_FlowConditions_FlowConditionId",
                table: "FlowLinks",
                column: "FlowConditionId",
                principalTable: "FlowConditions",
                principalColumn: "FlowConditionId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
