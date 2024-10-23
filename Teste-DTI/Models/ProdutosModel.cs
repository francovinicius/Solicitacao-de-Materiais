using System.ComponentModel.DataAnnotations;

namespace Teste_DTI.Models
{
    public class ProdutosModel
    {
        [Key]
        public int IdProduto { get; set; }
        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public string NomeProduto { get; set; }
        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public string EANProduto { get; set; }
        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public int ValorUnitarioProduto { get; set; }
        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public int QuantEstoqueProduto { get; set; }
    }
}
