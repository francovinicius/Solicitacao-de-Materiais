using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Teste_DTI.Migrations
{
    /// <inheritdoc />
    public partial class DbConect : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Servico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdFornecedores = table.Column<int>(type: "int", nullable: false),
                    FornecedoresIdFornecedores = table.Column<int>(type: "int", nullable: false),
                    DescricaoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrazoEntrega = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Fornecedores_FornecedoresIdFornecedores",
                        column: x => x.FornecedoresIdFornecedores,
                        principalTable: "Fornecedores",
                        principalColumn: "IdFornecedores",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Services_FornecedoresIdFornecedores",
                table: "Services",
                column: "FornecedoresIdFornecedores");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
