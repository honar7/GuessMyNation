using Microsoft.EntityFrameworkCore.Migrations;

namespace GuessMyNation.Infra.Data.Sql.Migrations
{
    public partial class addpathtoNationItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GameDetail_GameHeaderId",
                table: "GameDetail");

            migrationBuilder.AlterColumn<int>(
                name: "Point",
                table: "NationItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "NationItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GameDetail_GameHeaderId",
                table: "GameDetail",
                column: "GameHeaderId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_GameDetail_GameHeaderId",
                table: "GameDetail");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "NationItems");

            migrationBuilder.AlterColumn<byte>(
                name: "Point",
                table: "NationItems",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_GameDetail_GameHeaderId",
                table: "GameDetail",
                column: "GameHeaderId");
        }
    }
}
