using Microsoft.EntityFrameworkCore;
using Teste_DTI.Models;

namespace Teste_DTI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {  
        }

        //Tabelas
        public DbSet<FornecedoresModel> Fornecedores { get; set; }
        public DbSet<ProdutosModel> Produtos { get; set; }
        public DbSet<UsuariosModel> Usuarios { get; set; }
        public DbSet<ServicesModel> Services { get; set; }
        public DbSet<SolicitacaoMaterialModel> SolicitacoesMateriais { get; set; }

    }
}
