using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstRealApp.Migrations
{
    public partial class testaddingpoodlesDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Poodles",
                newName: "PoodleSizeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Poodles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Poodles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "GeneticTests",
                table: "Poodles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PedigreeNumber",
                table: "Poodles",
                type: "nvarchar(11)",
                maxLength: 11,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PoodleColorId",
                table: "Poodles",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoodleModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colors_Poodles_PoodleModelId",
                        column: x => x.PoodleModelId,
                        principalTable: "Poodles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PoodleModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sizes_Poodles_PoodleModelId",
                        column: x => x.PoodleModelId,
                        principalTable: "Poodles",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name", "PoodleModelId" },
                values: new object[,]
                {
                    { 1, "Black", null },
                    { 2, "White", null },
                    { 3, "Brown", null },
                    { 4, "Gray", null },
                    { 5, "Apricot", null },
                    { 6, "Red", null },
                    { 7, "Black and tan", null }
                });

            migrationBuilder.InsertData(
                table: "Poodles",
                columns: new[] { "Id", "DateOfBirth", "GeneticTests", "Name", "PedigreeNumber", "PoodleColorId", "PoodleSizeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Toy Love Story Don Juan", "JR 70883", 6, 2 },
                    { 2, new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Cici", "JR 81231", 5, 2 },
                    { 3, new DateTime(2018, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Greta Garbo Von Apalusso", "JR 70883", 5, 2 },
                    { 4, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Scarlet Rain  Von Apalusso", "JR 70883", 6, 1 },
                    { 5, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Skyler Von Apalusso", "JR 70883", 6, 2 },
                    { 6, new DateTime(2017, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Loko Loko Crveni Mayestoso", "JR 70883", 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "Name", "PoodleModelId" },
                values: new object[,]
                {
                    { 1, "Toy", null },
                    { 2, "Miniature", null },
                    { 3, "Medium", null },
                    { 4, "Standard", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colors_PoodleModelId",
                table: "Colors",
                column: "PoodleModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Sizes_PoodleModelId",
                table: "Sizes",
                column: "PoodleModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DeleteData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Poodles");

            migrationBuilder.DropColumn(
                name: "GeneticTests",
                table: "Poodles");

            migrationBuilder.DropColumn(
                name: "PedigreeNumber",
                table: "Poodles");

            migrationBuilder.DropColumn(
                name: "PoodleColorId",
                table: "Poodles");

            migrationBuilder.RenameColumn(
                name: "PoodleSizeId",
                table: "Poodles",
                newName: "Size");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Poodles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
