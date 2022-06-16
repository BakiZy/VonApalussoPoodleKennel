using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstRealApp.Migrations
{
    public partial class imagetestinglink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://lh3.googleusercontent.com/YUU9X3jy86ikEty5cx48BYA9E9REm62qmA4fyTMHQfw1KRMDZT5ye2LaK_7YZZmim838iTTYiidzaoX1Cs35UmtKBKdi7JgPHfQYZx7NJxZEN8ibR2zrUFNbz_qrFmsTIElIG3SflcHNH9IL4f28zvIjeBUc67xFNp51r2pohsD9zP3njqQ-WhB2zsd2GAGZIj3I6r6lOGfgWBamReWF_sa0-Itg7k5ERWWxXhQlhM8Y9mvyMTkMm-s2ZmwiEymzLqw8pEymEioTIwIvW9atTlvv8oXyEMmNPvBnwQsZzRjxw7XOubRTifjFI25IC_0RY-uWkBJIHxybhmkl39IRCfzmORSo0s9j5jmMN4-vsVJH6Pl-wDYrdARMb8kDaGmkUczj3JV3SUmunJHyj01q4HJHmLbx6IgRbBjvmP3Kpm6zFSpCh51UqQs06o6KCEpa4qCR8zwKALhfBWyKgeEVjEMAScRAbJc7x-CeF9Z4L4pK-sJQlTuoEIJ_D-0MtXnuB0I8wUks6wAlkKj_YYLB8nal3UUiP0uN2czrYKY-LI6Id4CfInMA460dCsMmam0F5OPno7Pi6d1z3qplMSXLLj6mqtHLP6TKNZXgoyUGnUgEAuu4Qj-Wv7pzVCbD0fLIC3ZhHCChiX7NjDaT-NOOc-M1aqGyrsiKtea7kG24mgKY780X5kagBOJn3_0XpxYC9JoY4NrVk27Y2Oao5TvHxlmgXLDdx4hzjnAWHvhOsatL72XrmzHYzfh0lJQ=w750-h937-no?authuser=0");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Poodles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://www.facebook.com/photo.php?fbid=10215740697750579&set=pb.1837427169.-2207520000..&type=3");
        }
    }
}
