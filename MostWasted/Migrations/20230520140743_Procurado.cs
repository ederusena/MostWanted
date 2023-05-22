using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MostWanted.Migrations
{
    /// <inheritdoc />
    public partial class Procurado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Procurado",
                columns: table => new
                {
                    ProcuradoId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NomeAgencia = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    NomeProcurado = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    FotoProcurado = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DataNascimento = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LugarNascimento = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Nacionalidade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    LinguaFalada = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Idade = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CorCabelo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    CorOlhos = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Sexo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Raca = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DescricaoCorporal = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    DescricaoRosto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Recompensa = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Acusacao = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Procurado", x => x.ProcuradoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Procurado");
        }
    }
}
