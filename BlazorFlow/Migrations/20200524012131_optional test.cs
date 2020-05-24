using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorFlow.Migrations
{
    public partial class optionaltest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowLink_FlowConditions_FlowConditionId",
                table: "FlowLink");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowLink_Flows_FlowId",
                table: "FlowLink");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowLink_FlowNodes_FlowNodeNextFlowNodeId",
                table: "FlowLink");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowLink_FlowNodes_FlowNodePreviousFlowNodeId",
                table: "FlowLink");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowNodes_Flows_FlowId",
                table: "FlowNodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlowLink",
                table: "FlowLink");

            migrationBuilder.RenameTable(
                name: "FlowLink",
                newName: "FlowLinks");

            migrationBuilder.RenameIndex(
                name: "IX_FlowLink_FlowNodePreviousFlowNodeId",
                table: "FlowLinks",
                newName: "IX_FlowLinks_FlowNodePreviousFlowNodeId");

            migrationBuilder.RenameIndex(
                name: "IX_FlowLink_FlowNodeNextFlowNodeId",
                table: "FlowLinks",
                newName: "IX_FlowLinks_FlowNodeNextFlowNodeId");

            migrationBuilder.RenameIndex(
                name: "IX_FlowLink_FlowId",
                table: "FlowLinks",
                newName: "IX_FlowLinks_FlowId");

            migrationBuilder.RenameIndex(
                name: "IX_FlowLink_FlowConditionId",
                table: "FlowLinks",
                newName: "IX_FlowLinks_FlowConditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlowLinks",
                table: "FlowLinks",
                column: "FlowLinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinks_FlowConditions_FlowConditionId",
                table: "FlowLinks",
                column: "FlowConditionId",
                principalTable: "FlowConditions",
                principalColumn: "FlowConditionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLinks_Flows_FlowId",
                table: "FlowLinks",
                column: "FlowId",
                principalTable: "Flows",
                principalColumn: "FlowId",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_FlowNodes_Flows_FlowId",
                table: "FlowNodes",
                column: "FlowId",
                principalTable: "Flows",
                principalColumn: "FlowId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_FlowConditions_FlowConditionId",
                table: "FlowLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_Flows_FlowId",
                table: "FlowLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_FlowNodes_FlowNodeNextFlowNodeId",
                table: "FlowLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowLinks_FlowNodes_FlowNodePreviousFlowNodeId",
                table: "FlowLinks");

            migrationBuilder.DropForeignKey(
                name: "FK_FlowNodes_Flows_FlowId",
                table: "FlowNodes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlowLinks",
                table: "FlowLinks");

            migrationBuilder.RenameTable(
                name: "FlowLinks",
                newName: "FlowLink");

            migrationBuilder.RenameIndex(
                name: "IX_FlowLinks_FlowNodePreviousFlowNodeId",
                table: "FlowLink",
                newName: "IX_FlowLink_FlowNodePreviousFlowNodeId");

            migrationBuilder.RenameIndex(
                name: "IX_FlowLinks_FlowNodeNextFlowNodeId",
                table: "FlowLink",
                newName: "IX_FlowLink_FlowNodeNextFlowNodeId");

            migrationBuilder.RenameIndex(
                name: "IX_FlowLinks_FlowId",
                table: "FlowLink",
                newName: "IX_FlowLink_FlowId");

            migrationBuilder.RenameIndex(
                name: "IX_FlowLinks_FlowConditionId",
                table: "FlowLink",
                newName: "IX_FlowLink_FlowConditionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlowLink",
                table: "FlowLink",
                column: "FlowLinkId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLink_FlowConditions_FlowConditionId",
                table: "FlowLink",
                column: "FlowConditionId",
                principalTable: "FlowConditions",
                principalColumn: "FlowConditionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLink_Flows_FlowId",
                table: "FlowLink",
                column: "FlowId",
                principalTable: "Flows",
                principalColumn: "FlowId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLink_FlowNodes_FlowNodeNextFlowNodeId",
                table: "FlowLink",
                column: "FlowNodeNextFlowNodeId",
                principalTable: "FlowNodes",
                principalColumn: "FlowNodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowLink_FlowNodes_FlowNodePreviousFlowNodeId",
                table: "FlowLink",
                column: "FlowNodePreviousFlowNodeId",
                principalTable: "FlowNodes",
                principalColumn: "FlowNodeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlowNodes_Flows_FlowId",
                table: "FlowNodes",
                column: "FlowId",
                principalTable: "Flows",
                principalColumn: "FlowId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
