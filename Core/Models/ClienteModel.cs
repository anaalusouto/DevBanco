using System.ComponentModel.DataAnnotations;

namespace CadastroClienteEmprestimo.Core.Models
{
    public class ClienteModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatorio")]
        public string Cpf { get; set; }

        public string Endereco { get; set; }

        [MaxLength(20, ErrorMessage = "O telefone nao pode ultrapassar 20 caracteres")]
        public string Telefone { get; set; }

        [EmailAddress(ErrorMessage = "Email em formato invalido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O salario é obrigatorio")]
        public float Salario { get; set; }

        public string ClassificacaoRisco { get; set; }
        
        public float LimiteCreditoPreAprovado { get; set; }
    }
}
