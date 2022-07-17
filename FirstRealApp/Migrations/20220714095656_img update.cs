using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstRealApp.Migrations
{
    public partial class imgupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://i.imgur.com/6Ll5PQL.jpeg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://i.imgur.com/2jlGebh.jpeg");
        }
    }
}
