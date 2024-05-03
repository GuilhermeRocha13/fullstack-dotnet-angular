using Microsoft.EntityFrameworkCore.Migrations;

namespace ProEvent.API.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    EventoID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    local = table.Column<string>(type: "TEXT", nullable: true),
                    dataEvento = table.Column<string>(type: "TEXT", nullable: true),
                    tema = table.Column<string>(type: "TEXT", nullable: true),
                    qtPessoas = table.Column<int>(type: "INTEGER", nullable: false),
                    lote = table.Column<int>(type: "INTEGER", nullable: false),
                    imagemURL = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventoID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
