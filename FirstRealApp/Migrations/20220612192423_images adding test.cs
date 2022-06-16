using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstRealApp.Migrations
{
    public partial class imagesaddingtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Poodles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://www.facebook.com/photo.php?fbid=10215740697750579&set=pb.1837427169.-2207520000..&type=3");

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "test");

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "test");

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "test3");

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "test22");

            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "test123");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Poodles");
        }
    }
}
