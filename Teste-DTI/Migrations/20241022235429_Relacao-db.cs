using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste_DTI.Migrations
{
    /// <inheritdoc />
    public partial class Relacaodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<int>(
                name: "NomeFornecedoresIdFornecedores",
                table: "Servicos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_NomeFornecedoresIdFornecedores",
                table: "Servicos",
                column: "NomeFornecedoresIdFornecedores");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Fornecedores_NomeFornecedoresIdFornecedores",
                table: "Servicos",
                column: "NomeFornecedoresIdFornecedores",
                principalTable: "Fornecedores",
                principalColumn: "IdFornecedores",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Fornecedores_NomeFornecedoresIdFornecedores",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_NomeFornecedoresIdFornecedores",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "NomeFornecedoresIdFornecedores",
                table: "Servicos");

            migrationBuilder.AddColumn<string>(
                name: "FornecedorKeyServico",
                table: "Servicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
