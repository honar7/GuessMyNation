using Microsoft.EntityFrameworkCore.Migrations;

namespace GuessMyNation.Infra.Data.Sql.Migrations
{
    public partial class refactornaming : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NationItems_GameDetail_GameDetailId",
                table: "NationItems");

            migrationBuilder.DropTable(
                name: "NationItemAmswer");

            migrationBuilder.DropIndex(
                name: "IX_NationItems_GameDetailId",
                table: "NationItems");

            migrationBuilder.DropColumn(
                name: "GameDetailId",
                table: "NationItems");

            migrationBuilder.CreateTable(
                name: "NationItemAnswer",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationId = table.Column<long>(type: "bigint", nullable: false),
                    AnswerCode = table.Column<long>(type: "bigint", nullable: true),
                    Point = table.Column<int>(type: "int", nullable: true),
                    GameDetailId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationItemAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NationItemAnswer_GameDetail_GameDetailId",
                        column: x => x.GameDetailId,
                        principalTable: "GameDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NationItemAnswer_GameDetailId",
                table: "NationItemAnswer",
                column: "GameDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationItemAnswer");

            migrationBuilder.AddColumn<long>(
                name: "GameDetailId",
                table: "NationItems",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NationItemAmswer",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerCode = table.Column<int>(type: "int", nullable: true),
                    GameDetailId = table.Column<long>(type: "bigint", nullable: true),
                    NationId = table.Column<long>(type: "bigint", nullable: false),
                    Point = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NationItemAmswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NationItemAmswer_GameDetail_GameDetailId",
                        column: x => x.GameDetailId,
                        principalTable: "GameDetail",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NationItems_GameDetailId",
                table: "NationItems",
                column: "GameDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_NationItemAmswer_GameDetailId",
                table: "NationItemAmswer",
                column: "GameDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_NationItems_GameDetail_GameDetailId",
                table: "NationItems",
                column: "GameDetailId",
                principalTable: "GameDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
