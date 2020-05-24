using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorFlow.Migrations
{
    public partial class changetorequiredfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_Flows_FlowId",
                table: "FlowLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowNodes_Flows_FlowId",
                table: "FlowNodes");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinks_Flows_FlowId",
                table: "FlowLinks",
                column: "FlowId",
                principalTable: "Flows",
                principalColumn: "FlowId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowNodes_Flows_FlowId",
                table: "FlowNodes",
                column: "FlowId",
                principalTable: "Flows",
                principalColumn: "FlowId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_Flows_FlowId",
                table: "FlowLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowNodes_Flows_FlowId",
                table: "FlowNodes");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinks_Flows_FlowId",
                table: "FlowLinks",
                column: "FlowId",
                principalTable: "Flows",
                principalColumn: "FlowId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowNodes_Flows_FlowId",
                table: "FlowNodes",
                column: "FlowId",
                principalTable: "Flows",
                principalColumn: "FlowId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
