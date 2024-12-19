using CadastroClienteEmprestimo.Core.Interface;
using CadastroClienteEmprestimo.Core.Models;
using CadastroClienteEmprestimo.Infra;
using CadastroClienteEmprestimo.Pesentation.Dto;

namespace CadastroClienteEmprestimo.Core.UseCase
{
    public class CadastrarClienteUseCase : ICadastrarClienteUseCase
    {
        private readonly AppDbContext _context;
        public CadastrarClienteUseCase(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ClienteModel> CadastrarCliente(ClienteCreateDto clienteCreateDto)
        {
            var cliente = new ClienteModel
            {
                Nome = clienteCreateDto.Nome,
                Cpf = clienteCreateDto.Cpf,
                Endereco = clienteCreateDto.Endereco,
                Telefone = clienteCreateDto.Telefone,
                Email = clienteCreateDto.Email,
                Salario = (float)clienteCreateDto.Salario
            };

            AnalisarCredito(cliente);

            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

            return cliente;

        }

        private void AnalisarCredito(ClienteModel cliente)
        {
            if (cliente.Salario > 5000)
            {
                cliente.ClassificacaoRisco = "Baixo";
                cliente.LimiteCreditoPreAprovado = (float)20000m;
            }
            else
            {
                cliente.ClassificacaoRisco = "Médio";
                cliente.LimiteCreditoPreAprovado = (float)10000m;
            }
        }
    }
}
