using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_Cadastro_e_Gerenciamento_de_Clientes.Migrations
{
    /// <inheritdoc />
    public partial class BancoCorreto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_TitularId",
                table: "Contas");

            migrationBuilder.RenameColumn(
                name: "TitularId",
                table: "Contas",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Contas_TitularId",
                table: "Contas",
                newName: "IX_Contas_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contas_Clientes_ClienteId",
                table: "Contas");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Contas",
                newName: "TitularId");

            migrationBuilder.RenameIndex(
                name: "IX_Contas_ClienteId",
                table: "Contas",
                newName: "IX_Contas_TitularId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contas_Clientes_TitularId",
                table: "Contas",
                column: "TitularId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
