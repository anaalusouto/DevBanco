namespace ClienteCRUD.Core.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }
        public string? CPF { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? Cellphone { get; set; }
        public DateTime? Data_Nascimento { get; set; }
    }
}
