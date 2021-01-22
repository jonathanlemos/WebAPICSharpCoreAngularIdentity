using Microsoft.EntityFrameworkCore.Migrations;

namespace Contexto.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    primeiroNome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    numero = table.Column<int>(type: "int", nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cepId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sexoIdM = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "id", "cepId", "cidade", "complemento", "email", "endereco", "estado", "nomeCompleto", "numero", "primeiroNome", "senha", "sexoIdM" },
                values: new object[] { 1, "12345", "cidade nv", "compl", "teste@teste.com", "end", "rj", "nm completo", 1, "primeiro nm", "123", "M" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
