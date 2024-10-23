using System.ComponentModel.DataAnnotations;

namespace Teste_DTI.Models
{
    public class FornecedoresModel
    {
        [Key]
        public int IdFornecedores { get; set; }
        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public string NomeFornecedores { get; set; }
        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public string EnderecoFornecedores { get; set; }
        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public string EmailFornecedores { get; set; }
        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public string CNPJFornecedores { get; set; }
        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public string InscricaoEstatualFornecedores { get; set; }
        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public string InscricaoMunicipalFornecedores { get; set; }

    }
}
