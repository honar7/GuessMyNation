using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuessMyNation.Infra.Data.Sql.Migrations
{
    public partial class AddGameDetailToGameHeader : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameDetail",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameHeaderId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameDetail_Games_GameHeaderId",
                        column: x => x.GameHeaderId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NationItem",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nationId = table.Column<long>(type: "bigint", nullable: true),
                    Photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    AnswerCode = table.Column<int>(type: "int", nullable: true),
                    Point = table.Column<byte>(type: "tinyint", nullable: true),
                    GameDetailId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NationItem_GameDetail_GameDetailId",
                        column: x => x.GameDetailId,
                        principalTable: "GameDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NationItem_Nations_nationId",
                        column: x => x.nationId,
                        principalTable: "Nations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameDetail_GameHeaderId",
                table: "GameDetail",
                column: "GameHeaderId");

            migrationBuilder.CreateIndex(
                name: "IX_NationItem_GameDetailId",
                table: "NationItem",
                column: "GameDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_NationItem_nationId",
                table: "NationItem",
                column: "nationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationItem");

            migrationBuilder.DropTable(
                name: "GameDetail");
        }
    }
}
