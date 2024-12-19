using System.ComponentModel.DataAnnotations;

namespace CadastroClienteEmprestimo.Pesentation.Dto
{
    public class ClienteCreateDto
    {
        [Required(ErrorMessage = "O nome é obrigatorio")]
        public string Nome { get; set; } = default!;

        [Required(ErrorMessage = "O CPF é obrigatorio")]
        [StringLength(11, ErrorMessage = "O CPF deve conter 11 caracteres")]
        public string Cpf { get; set; } = default!;

        public string? Endereco { get; set; }

        [MaxLength(20, ErrorMessage = "O telefone não pode ultrapassar 20 caracteres")]
        public string? Telefone { get; set; }

        [EmailAddress(ErrorMessage = "Email em formato invalido")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "O salario é obrigatorio")]
        public decimal Salario { get; set; }
    }
}
