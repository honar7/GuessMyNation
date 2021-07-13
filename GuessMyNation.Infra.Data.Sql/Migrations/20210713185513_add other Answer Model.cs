using Microsoft.EntityFrameworkCore.Migrations;

namespace GuessMyNation.Infra.Data.Sql.Migrations
{
    public partial class addotherAnswerModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NationItemAmswer",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationId = table.Column<long>(type: "bigint", nullable: false),
                    AnswerCode = table.Column<int>(type: "int", nullable: true),
                    Point = table.Column<int>(type: "int", nullable: true),
                    GameDetailId = table.Column<long>(type: "bigint", nullable: true)
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
                name: "IX_NationItemAmswer_GameDetailId",
                table: "NationItemAmswer",
                column: "GameDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NationItemAmswer");
        }
    }
}
