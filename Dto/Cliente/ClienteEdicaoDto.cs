namespace API_Cadastro_e_Gerenciamento_de_Clientes.Dto.Cliente
{
    public class ClienteEdicaoDto
    {
        public int Id { get; set; }
        public string Endereco { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
    }
}
