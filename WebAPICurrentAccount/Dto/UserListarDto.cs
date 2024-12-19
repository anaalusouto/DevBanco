namespace WebAPICurrentAccount.Dto
{
    public class UserListarDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }
        public double Saldo { get; set; }
        public bool StatusUser { get; set; } //True = Ativo False = Bloqueado
    }
}
