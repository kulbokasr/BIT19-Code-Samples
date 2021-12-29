using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistracijosApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pozymiai",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReiksmeId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pozymiai", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reiksmes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PozymisId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reiksmes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reiksmes_Pozymiai_PozymisId",
                        column: x => x.PozymisId,
                        principalTable: "Pozymiai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reiksmes_PozymisId",
                table: "Reiksmes",
                column: "PozymisId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reiksmes");

            migrationBuilder.DropTable(
                name: "Pozymiai");
        }
    }
}
