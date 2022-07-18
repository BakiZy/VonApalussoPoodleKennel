using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstRealApp.Migrations
{
    public partial class testingid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "GeneticTests", "Image", "Name", "PedigreeNumber", "PoodleColorId", "PoodleSizeId" },
                values: new object[] { new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "https://i.imgur.com/6Ll5PQL.jpeg", "Scarlet Rain  Von Apalusso", "JR 70883", 6, 1 });

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "Image", "Name", "PoodleColorId", "PoodleSizeId" },
                values: new object[] { new DateTime(2017, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://i.imgur.com/QnE8Brd.jpeg", "Loko Loko Crveni Mayestoso", 7, 1 });

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GeneticTests", "Image", "Name", "PoodleSizeId" },
                values: new object[] { false, "https://i.imgur.com/nuBvd3X.jpeg", "Skyler Von Apalusso", 2 });

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "GeneticTests", "Image", "Name", "PoodleColorId" },
                values: new object[] { new DateTime(2018, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "https://i.imgur.com/gHWcJsQ.jpeg", "Greta Garbo Von Apalusso", 5 });

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "GeneticTests", "Image", "Name", "PedigreeNumber", "PoodleColorId", "PoodleSizeId" },
                values: new object[] { new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "https://i.imgur.com/7RetPeR.jpg", "Cici", "JR 81231", 5, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "GeneticTests", "Image", "Name", "PedigreeNumber", "PoodleColorId", "PoodleSizeId" },
                values: new object[] { new DateTime(2020, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "https://i.imgur.com/7RetPeR.jpg", "Cici", "JR 81231", 5, 2 });

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "Image", "Name", "PoodleColorId", "PoodleSizeId" },
                values: new object[] { new DateTime(2018, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://i.imgur.com/gHWcJsQ.jpeg", "Greta Garbo Von Apalusso", 5, 2 });

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "GeneticTests", "Image", "Name", "PoodleSizeId" },
                values: new object[] { true, "https://i.imgur.com/6Ll5PQL.jpeg", "Scarlet Rain  Von Apalusso", 1 });

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "GeneticTests", "Image", "Name", "PoodleColorId" },
                values: new object[] { new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "https://i.imgur.com/nuBvd3X.jpeg", "Skyler Von Apalusso", 6 });

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "GeneticTests", "Image", "Name", "PedigreeNumber", "PoodleColorId", "PoodleSizeId" },
                values: new object[] { new DateTime(2017, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "https://i.imgur.com/QnE8Brd.jpeg", "Loko Loko Crveni Mayestoso", "JR 70883", 7, 1 });
        }
    }
}
