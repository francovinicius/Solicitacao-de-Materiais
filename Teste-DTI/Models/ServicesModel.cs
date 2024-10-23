using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Teste_DTI.Models
{
    public class ServicesModel
    {
        [Key]
        public int Id { get; set; }

        public string Servico { get; set; }
        public int FornecedoresIdFornecedores { get; set; }
        [NotMapped]
        public string NomeFornecedores { get; set; }

        public string DescricaoServico { get; set; }
        public string PrazoEntrega { get; set; }

        [NotMapped]
        public List<FornecedoresModel> ListaFornecedores { get; set; }
    }
}