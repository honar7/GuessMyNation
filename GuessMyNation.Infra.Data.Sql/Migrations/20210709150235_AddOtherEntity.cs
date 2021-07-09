using Microsoft.EntityFrameworkCore.Migrations;

namespace GuessMyNation.Infra.Data.Sql.Migrations
{
    public partial class AddOtherEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NationItem_GameDetail_GameDetailId",
                table: "NationItem");

            migrationBuilder.DropForeignKey(
                name: "FK_NationItem_Nations_nationId",
                table: "NationItem");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NationItem",
                table: "NationItem");

            migrationBuilder.RenameTable(
                name: "NationItem",
                newName: "NationItems");

            migrationBuilder.RenameColumn(
                name: "ToralScore",
                table: "Games",
                newName: "TotalScore");

            migrationBuilder.RenameIndex(
                name: "IX_NationItem_nationId",
                table: "NationItems",
                newName: "IX_NationItems_nationId");

            migrationBuilder.RenameIndex(
                name: "IX_NationItem_GameDetailId",
                table: "NationItems",
                newName: "IX_NationItems_GameDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationItems",
                table: "NationItems",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_NationItems_GameDetail_GameDetailId",
                table: "NationItems",
                column: "GameDetailId",
                principalTable: "GameDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationItems_Nations_nationId",
                table: "NationItems",
                column: "nationId",
                principalTable: "Nations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NationItems_GameDetail_GameDetailId",
                table: "NationItems");

            migrationBuilder.DropForeignKey(
                name: "FK_NationItems_Nations_nationId",
                table: "NationItems");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NationItems",
                table: "NationItems");

            migrationBuilder.RenameTable(
                name: "NationItems",
                newName: "NationItem");

            migrationBuilder.RenameColumn(
                name: "TotalScore",
                table: "Games",
                newName: "ToralScore");

            migrationBuilder.RenameIndex(
                name: "IX_NationItems_nationId",
                table: "NationItem",
                newName: "IX_NationItem_nationId");

            migrationBuilder.RenameIndex(
                name: "IX_NationItems_GameDetailId",
                table: "NationItem",
                newName: "IX_NationItem_GameDetailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NationItem",
                table: "NationItem",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desciption = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    EnName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_NationItem_GameDetail_GameDetailId",
                table: "NationItem",
                column: "GameDetailId",
                principalTable: "GameDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NationItem_Nations_nationId",
                table: "NationItem",
                column: "nationId",
                principalTable: "Nations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
