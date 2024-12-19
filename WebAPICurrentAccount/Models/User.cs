namespace WebAPICurrentAccount.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Password { get; set; }
        public string CPF { get; set; }
        public string Contato { get; set; }

        public double Saldo { get; set; }
        public bool StatusUser { get; set; } //True = Ativo False = Bloqueado
        public string AccountNum { get; set; }
        public int Agency { get; set; }
        
    }
}
