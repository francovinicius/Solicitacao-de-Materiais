using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Teste_DTI.Models
{
    public class SolicitacaoMaterialModel
    {
        [Key]
        public int IdSolicitacao { get; set; }

        [Required]
        [ForeignKey("Produto")]
        public int IdProduto { get; set; }

        [NotMapped]
        public string NomeProduto { get; set; }

        [Required]
        public string Fabricante { get; set; }

        [Required]
        public int Quantidade { get; set; }

        [Required]
        public string Departamento { get; set; }

        [Required]
        public string Usuario { get; set; }


        public ProdutosModel Produto { get; set; }

    }
}

