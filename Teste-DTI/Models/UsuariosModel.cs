using System.ComponentModel.DataAnnotations;

namespace Teste_DTI.Models
{
    public class UsuariosModel
    {
        [Key]
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public string MatriculaUsuario { get; set; }
        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public string NomeUsuario { get; set; }
        [Required(ErrorMessage = "Preencha o campo corretamente")]
        public string DepartamentoUsuario { get; set; }

    }
}
