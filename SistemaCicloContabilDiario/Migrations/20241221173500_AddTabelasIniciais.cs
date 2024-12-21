using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaCicloContabilDiario.Migrations
{
    /// <inheritdoc />
    public partial class AddTabelasIniciais : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CategoriasTransacao",
                columns: table => new
                {
                    CategoriaTransacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriasTransacao", x => x.CategoriaTransacaoId);
                });

            migrationBuilder.CreateTable(
                name: "Montantes",
                columns: table => new
                {
                    MontanteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValorMontante = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Montantes", x => x.MontanteId);
                });

            migrationBuilder.CreateTable(
                name: "TiposTransacao",
                columns: table => new
                {
                    TipoTransacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposTransacao", x => x.TipoTransacaoId);
                });

            migrationBuilder.CreateTable(
                name: "Transacoes",
                columns: table => new
                {
                    TransacaoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoTransacaoId = table.Column<int>(type: "int", nullable: false),
                    CategoriaTransacaoId = table.Column<int>(type: "int", nullable: false),
                    MontanteId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdContaOrigem = table.Column<int>(type: "int", nullable: false),
                    IdContaDestino = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transacoes", x => x.TransacaoId);
                    table.ForeignKey(
                        name: "FK_Transacoes_CategoriasTransacao_CategoriaTransacaoId",
                        column: x => x.CategoriaTransacaoId,
                        principalTable: "CategoriasTransacao",
                        principalColumn: "CategoriaTransacaoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transacoes_Montantes_MontanteId",
                        column: x => x.MontanteId,
                        principalTable: "Montantes",
                        principalColumn: "MontanteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transacoes_TiposTransacao_TipoTransacaoId",
                        column: x => x.TipoTransacaoId,
                        principalTable: "TiposTransacao",
                        principalColumn: "TipoTransacaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_CategoriaTransacaoId",
                table: "Transacoes",
                column: "CategoriaTransacaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_MontanteId",
                table: "Transacoes",
                column: "MontanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Transacoes_TipoTransacaoId",
                table: "Transacoes",
                column: "TipoTransacaoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Transacoes");

            migrationBuilder.DropTable(
                name: "CategoriasTransacao");

            migrationBuilder.DropTable(
                name: "Montantes");

            migrationBuilder.DropTable(
                name: "TiposTransacao");
        }
    }
}
