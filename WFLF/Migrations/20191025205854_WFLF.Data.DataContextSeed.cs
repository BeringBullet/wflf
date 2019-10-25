using Microsoft.EntityFrameworkCore.Migrations;

namespace WFLF.Migrations
{
    public partial class WFLFDataDataContextSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Role", "Username" },
                values: new object[] { 1, "Mike", "Walters", null, null, "Admin", "mwalters" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
