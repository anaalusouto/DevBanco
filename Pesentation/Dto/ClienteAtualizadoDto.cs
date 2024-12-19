using System.ComponentModel.DataAnnotations;

namespace CadastroClienteEmprestimo.Pesentation.Dto
{
    public class ClienteAtualizadoDto
    {
        public string? Nome { get; set; }

        public string? Cpf { get; set; }

        public string? Endereco { get; set; }

        [Phone]
        public string? Telefone { get; set; }

        [EmailAddress]
        public string? Email { get; set; }

        public decimal? Salario { get; set; }
    }
}
