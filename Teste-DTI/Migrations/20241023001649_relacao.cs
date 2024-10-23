using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste_DTI.Migrations
{
    /// <inheritdoc />
    public partial class relacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Servico");

            migrationBuilder.DropTable(
                name: "Servicos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFornecedoresIdFornecedores = table.Column<int>(type: "int", nullable: false),
                    DescricaoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FornecedorId = table.Column<int>(type: "int", nullable: false),
                    NomeServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrazoEntregaServico = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servico_Fornecedores_NomeFornecedoresIdFornecedores",
                        column: x => x.NomeFornecedoresIdFornecedores,
                        principalTable: "Fornecedores",
                        principalColumn: "IdFornecedores",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFornecedoresIdFornecedores = table.Column<int>(type: "int", nullable: false),
                    DescricaoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FornecedorId = table.Column<int>(type: "int", nullable: false),
                    NomeServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrazoEntregaServico = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servicos_Fornecedores_NomeFornecedoresIdFornecedores",
                        column: x => x.NomeFornecedoresIdFornecedores,
                        principalTable: "Fornecedores",
                        principalColumn: "IdFornecedores",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servico_NomeFornecedoresIdFornecedores",
                table: "Servico",
                column: "NomeFornecedoresIdFornecedores");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_NomeFornecedoresIdFornecedores",
                table: "Servicos",
                column: "NomeFornecedoresIdFornecedores");
        }
    }
}
