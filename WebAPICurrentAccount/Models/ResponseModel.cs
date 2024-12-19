namespace WebAPICurrentAccount.Models
{
    public class ResponseModel<Geral>
    {
        public Geral? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Situação { get; set; } = true;
    }
}
