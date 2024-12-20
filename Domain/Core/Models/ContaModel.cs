using ClienteCRUD.Core.Models.Enums;

namespace ClienteCRUD.Core.Models
{
    public class ContaModel
    {
        public int Id { get; set; }
        public int? Agencia { get; set; }
        public string? Senha { get; set; }
        public StatusConta Status { get; set; }

        public ContaModel()
        {
        }

    }
}
