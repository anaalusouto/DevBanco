namespace APIPagamentoOnline.Infra.Mock
{
    public class MockClienteService
    {
        public Task<ClienteMockModel> ObterDadosClienteAsync(int clienteId)
        {
            var cliente = new ClienteMockModel
            {
                ClienteId = clienteId,
                Nome = "Placeholder",
                NumConta = 123456,
                Saldo = 5000
            };
            return Task.FromResult(cliente);
        }
    }
}
