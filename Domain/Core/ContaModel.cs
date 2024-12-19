using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core
{
    public class ContaModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O número da conta é obrigatório.")]
        public string Numero { get; set; } // String para manter zeros à esquerda

        [Required(ErrorMessage = "A agência é obrigatória.")]
        public string Agencia { get; set; } // String por causa dos zeros à esquerda

        [Required(ErrorMessage = "O titular é obrigatório.")]
        [ForeignKey("ClienteId")]
        public ClienteModel Titular { get; set; } = default!; // Propriedade de navegação

        public int ClienteId { get; set; } // Chave estrangeira para Cliente

        public float Saldo { get; set; } = 0;
    }
}
