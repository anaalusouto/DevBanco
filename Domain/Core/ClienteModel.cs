using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core
{
    public class ClienteModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "O CPF é obrigatório.")]
        public string Cpf { get; set; } = string.Empty;
        public string Endereco { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public ICollection<ContaModel> Contas { get; set; } = new List<ContaModel>();
    }
}
