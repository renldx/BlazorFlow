using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BlazorFlow.Migrations
{
    public partial class newjointable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlowAnswers_FlowNodes_FlowNodeId",
                table: "FlowAnswers");

            migrationBuilder.DropIndex(
                name: "IX_FlowAnswers_FlowNodeId",
                table: "FlowAnswers");

            migrationBuilder.DropColumn(
                name: "FlowNodeId",
                table: "FlowAnswers");

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

            migrationBuilder.CreateIndex(
                name: "IX_FlowNodeAnswers_FlowAnswerId",
                table: "FlowNodeAnswers",
                column: "FlowAnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_FlowNodeAnswers_FlowNodeId",
                table: "FlowNodeAnswers",
                column: "FlowNodeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlowNodeAnswers");

            migrationBuilder.AddColumn<int>(
                name: "FlowNodeId",
                table: "FlowAnswers",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FlowAnswers_FlowNodeId",
                table: "FlowAnswers",
                column: "FlowNodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlowAnswers_FlowNodes_FlowNodeId",
                table: "FlowAnswers",
                column: "FlowNodeId",
                principalTable: "FlowNodes",
                principalColumn: "FlowNodeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
