using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoListApplication.Migrations
{
    public partial class addingtodo1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[] { 2, null, null, "Todo2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "CategoryId", "Description", "Name" },
                values: new object[] { 1, null, null, "Todo1" });
        }
    }
}
