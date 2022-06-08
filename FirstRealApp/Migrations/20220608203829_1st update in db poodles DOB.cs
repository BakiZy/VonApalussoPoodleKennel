using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstRealApp.Migrations
{
    public partial class _1stupdateindbpoodlesDOB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colors_Poodles_PoodleModelId",
                table: "Colors");

            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_Poodles_PoodleModelId",
                table: "Sizes");

            migrationBuilder.RenameColumn(
                name: "PoodleModelId",
                table: "Sizes",
                newName: "PoodleId");

            migrationBuilder.RenameIndex(
                name: "IX_Sizes_PoodleModelId",
                table: "Sizes",
                newName: "IX_Sizes_PoodleId");

            migrationBuilder.RenameColumn(
                name: "PoodleModelId",
                table: "Colors",
                newName: "PoodleId");

            migrationBuilder.RenameIndex(
                name: "IX_Colors_PoodleModelId",
                table: "Colors",
                newName: "IX_Colors_PoodleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_Poodles_PoodleId",
                table: "Colors",
                column: "PoodleId",
                principalTable: "Poodles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_Poodles_PoodleId",
                table: "Sizes",
                column: "PoodleId",
                principalTable: "Poodles",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colors_Poodles_PoodleId",
                table: "Colors");

            migrationBuilder.DropForeignKey(
                name: "FK_Sizes_Poodles_PoodleId",
                table: "Sizes");

            migrationBuilder.RenameColumn(
                name: "PoodleId",
                table: "Sizes",
                newName: "PoodleModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Sizes_PoodleId",
                table: "Sizes",
                newName: "IX_Sizes_PoodleModelId");

            migrationBuilder.RenameColumn(
                name: "PoodleId",
                table: "Colors",
                newName: "PoodleModelId");

            migrationBuilder.RenameIndex(
                name: "IX_Colors_PoodleId",
                table: "Colors",
                newName: "IX_Colors_PoodleModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_Poodles_PoodleModelId",
                table: "Colors",
                column: "PoodleModelId",
                principalTable: "Poodles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Sizes_Poodles_PoodleModelId",
                table: "Sizes",
                column: "PoodleModelId",
                principalTable: "Poodles",
                principalColumn: "Id");
        }
    }
}
