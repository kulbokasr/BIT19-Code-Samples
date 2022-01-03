using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistracijosApp.Migrations
{
    public partial class severalRegistrations1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registracijos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegId = table.Column<int>(type: "int", nullable: false),
                    ReiksmeId = table.Column<int>(type: "int", nullable: false),
                    PozymisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registracijos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Registracijos_Pozymiai_PozymisId",
                        column: x => x.PozymisId,
                        principalTable: "Pozymiai",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Registracijos_Reiksmes_ReiksmeId",
                        column: x => x.ReiksmeId,
                        principalTable: "Reiksmes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Registracijos_PozymisId",
                table: "Registracijos",
                column: "PozymisId");

            migrationBuilder.CreateIndex(
                name: "IX_Registracijos_ReiksmeId",
                table: "Registracijos",
                column: "ReiksmeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Registracijos");
        }
    }
}
