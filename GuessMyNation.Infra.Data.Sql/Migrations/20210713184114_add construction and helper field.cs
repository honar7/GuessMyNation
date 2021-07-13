using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GuessMyNation.Infra.Data.Sql.Migrations
{
    public partial class addconstructionandhelperfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NationItems_Nations_nationId",
                table: "NationItems");

            migrationBuilder.DropColumn(
                name: "Photo",
                table: "NationItems");

            migrationBuilder.RenameColumn(
                name: "nationId",
                table: "NationItems",
                newName: "NationId");

            migrationBuilder.RenameIndex(
                name: "IX_NationItems_nationId",
                table: "NationItems",
                newName: "IX_NationItems_NationId");

            migrationBuilder.AlterColumn<long>(
                name: "NationId",
                table: "NationItems",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NationItems_Nations_NationId",
                table: "NationItems",
                column: "NationId",
                principalTable: "Nations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NationItems_Nations_NationId",
                table: "NationItems");

            migrationBuilder.RenameColumn(
                name: "NationId",
                table: "NationItems",
                newName: "nationId");

            migrationBuilder.RenameIndex(
                name: "IX_NationItems_NationId",
                table: "NationItems",
                newName: "IX_NationItems_nationId");

            migrationBuilder.AlterColumn<long>(
                name: "nationId",
                table: "NationItems",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<byte[]>(
                name: "Photo",
                table: "NationItems",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_NationItems_Nations_nationId",
                table: "NationItems",
                column: "nationId",
                principalTable: "Nations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
