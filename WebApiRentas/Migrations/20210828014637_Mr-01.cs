using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiRentas.Migrations
{
    public partial class Mr01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Renta",
                columns: table => new
                {
                    RentaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaRenta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDevolucion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PeliculaId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renta", x => x.RentaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Renta");
        }
    }
}
