using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste_DTI.Migrations
{
    /// <inheritdoc />
    public partial class addSolicitacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitacoes_Produtos_IdProduto",
                table: "Solicitacoes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Solicitacoes",
                table: "Solicitacoes");

            migrationBuilder.RenameTable(
                name: "Solicitacoes",
                newName: "Solicitacao");

            migrationBuilder.RenameIndex(
                name: "IX_Solicitacoes_IdProduto",
                table: "Solicitacao",
                newName: "IX_Solicitacao_IdProduto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Solicitacao",
                table: "Solicitacao",
                column: "IdSolicitacao");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitacao_Produtos_IdProduto",
                table: "Solicitacao",
                column: "IdProduto",
                principalTable: "Produtos",
                principalColumn: "IdProduto",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitacao_Produtos_IdProduto",
                table: "Solicitacao");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Solicitacao",
                table: "Solicitacao");

            migrationBuilder.RenameTable(
                name: "Solicitacao",
                newName: "Solicitacoes");

            migrationBuilder.RenameIndex(
                name: "IX_Solicitacao_IdProduto",
                table: "Solicitacoes",
                newName: "IX_Solicitacoes_IdProduto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Solicitacoes",
                table: "Solicitacoes",
                column: "IdSolicitacao");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitacoes_Produtos_IdProduto",
                table: "Solicitacoes",
                column: "IdProduto",
                principalTable: "Produtos",
                principalColumn: "IdProduto",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
