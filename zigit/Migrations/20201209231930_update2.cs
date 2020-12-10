using Microsoft.EntityFrameworkCore.Migrations;

namespace zigit.Migrations
{
    public partial class update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "BugsCount", "DurationInDays", "MadeDadeline", "Name", "Score" },
                values: new object[] { 1, 3, (byte)7, true, "Full Stack Dev", (byte)100 });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "BugsCount", "DurationInDays", "MadeDadeline", "Name", "Score" },
                values: new object[] { 2, 1, (byte)20, true, "Python Web Scraping", (byte)93 });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "BugsCount", "DurationInDays", "MadeDadeline", "Name", "Score" },
                values: new object[] { 3, 6, (byte)2, true, "Fintech Marketing", (byte)88 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "ProjectId" },
                values: new object[] { 1, "ormizrahi777@gmail.com", "aaa111", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "ProjectId" },
                values: new object[] { 2, "yifatpaldi@gmail.com", "bbb222", 2 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Password", "ProjectId" },
                values: new object[] { 3, "shmuelm@gmail.com", "ccc333", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
