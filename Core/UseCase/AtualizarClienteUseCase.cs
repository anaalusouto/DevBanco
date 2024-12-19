using CadastroClienteEmprestimo.Core.Interface;
using CadastroClienteEmprestimo.Core.Models;
using CadastroClienteEmprestimo.Infra;
using CadastroClienteEmprestimo.Pesentation.Dto;
using Microsoft.EntityFrameworkCore;

namespace CadastroClienteEmprestimo.Core.UseCase
{
    public class AtualizarClienteUseCase : IAtualizarClienteUseCase
    {
        private readonly AppDbContext _context;

        public AtualizarClienteUseCase(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ClienteModel?> AtualizarCliente(int id, ClienteAtualizadoDto clienteAtualizadoDto)
        {
            var cliente = await _context.Clientes.FirstOrDefaultAsync(clienteBanco => clienteBanco.Id == id);

            if (cliente == null)
                return null;

            if (clienteAtualizadoDto.Nome != null) cliente.Nome = clienteAtualizadoDto.Nome;
            if (clienteAtualizadoDto.Cpf != null) cliente.Cpf = clienteAtualizadoDto.Cpf;
            if (clienteAtualizadoDto.Endereco != null) cliente.Endereco = clienteAtualizadoDto.Endereco;
            if (clienteAtualizadoDto.Telefone != null) cliente.Telefone = clienteAtualizadoDto.Telefone;
            if (clienteAtualizadoDto.Email != null) cliente.Email = clienteAtualizadoDto.Email;

            if (clienteAtualizadoDto.Salario.HasValue)
            {
                cliente.Salario = (float)clienteAtualizadoDto.Salario.Value;
                AnalisarCredito(cliente);
            }

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
