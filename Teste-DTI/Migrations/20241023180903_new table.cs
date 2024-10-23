using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste_DTI.Migrations
{
    /// <inheritdoc />
    public partial class newtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_Fornecedores_FornecedoresIdFornecedores",
                table: "Services");

            migrationBuilder.DropIndex(
                name: "IX_Services_FornecedoresIdFornecedores",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "IdFornecedores",
                table: "Services");

            migrationBuilder.CreateTable(
                name: "Solicitacoes",
                columns: table => new
                {
                    IdSolicitacao = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProduto = table.Column<int>(type: "int", nullable: false),
                    NomeProduto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fabricante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Departamento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Solicitacoes", x => x.IdSolicitacao);
                    table.ForeignKey(
                        name: "FK_Solicitacoes_Produtos_IdProduto",
                        column: x => x.IdProduto,
                        principalTable: "Produtos",
                        principalColumn: "IdProduto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Solicitacoes_IdProduto",
                table: "Solicitacoes",
                column: "IdProduto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Solicitacoes");

            migrationBuilder.AddColumn<int>(
                name: "IdFornecedores",
                table: "Services",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Services_FornecedoresIdFornecedores",
                table: "Services",
                column: "FornecedoresIdFornecedores");

            migrationBuilder.AddForeignKey(
                name: "FK_Services_Fornecedores_FornecedoresIdFornecedores",
                table: "Services",
                column: "FornecedoresIdFornecedores",
                principalTable: "Fornecedores",
                principalColumn: "IdFornecedores",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
