using API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core;
using API_Cadastro_e_Gerenciamento_de_Clientes.Dto.Cliente;
using API_Cadastro_e_Gerenciamento_de_Clientes.Infra;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Net;

namespace API_Cadastro_e_Gerenciamento_de_Clientes.Services.Cliente
{
    public class ClienteService : IClienteInterface
    {
        private readonly AppDbContext _context;
        public ClienteService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<ResponseModel<ClienteModel>> BuscarClientePorCpf(string cpfCliente)
        {
            ResponseModel<ClienteModel> resposta = new ResponseModel<ClienteModel>();
            try
            {

                var cliente = await _context.Clientes.FirstOrDefaultAsync(clienteBanco => clienteBanco.Cpf == cpfCliente);

                if (cliente == null)
                {
                    resposta.Mensagem = "Nenhum registro localizado";
                    return resposta;
                }

                resposta.Dados = cliente;
                resposta.Mensagem = "Cliente Localizado";

                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }

        public async Task<ResponseModel<ClienteModel>> BuscarClientePorId(int idCliente)
        {
            ResponseModel<ClienteModel> resposta = new ResponseModel<ClienteModel>();
            try
            {

                var cliente = await _context.Clientes.FirstOrDefaultAsync(clienteBanco => clienteBanco.Id == idCliente);

                if (cliente == null)
                {
                    resposta.Mensagem = "Nenhum registro localizado";
                    return resposta;
                }

                resposta.Dados = cliente;
                resposta.Mensagem = "Cliente Localizado";

                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }

        public async Task<ResponseModel<ClienteModel>> BuscarClientePorNome(string nameCliente)
        {
            ResponseModel<ClienteModel> resposta = new ResponseModel<ClienteModel>();
            try
            {

                var cliente = await _context.Clientes.FirstOrDefaultAsync(clienteBanco => clienteBanco.Name == nameCliente);

                if (cliente == null)
                {
                    resposta.Mensagem = "Nenhum registro localizado";
                    return resposta;
                }

                resposta.Dados = cliente;
                resposta.Mensagem = "Cliente Localizado";

                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }

        public async Task<ResponseModel<List<ClienteModel>>> EditarCliente(ClienteEdicaoDto clienteEdicaoDto)
        {
            ResponseModel<List<ClienteModel>> resposta = new ResponseModel<List<ClienteModel>>();
            try
            {
                var cliente = await _context.Clientes.FirstOrDefaultAsync(clienteBanco => clienteBanco.Id == clienteEdicaoDto.Id);

                if (cliente == null)
                {
                    resposta.Mensagem = "Nenhum cliente localizado";
                    return resposta;
                }

                cliente.Endereco = clienteEdicaoDto.Endereco;
                cliente.Email = clienteEdicaoDto.Email;
                cliente.Telefone = clienteEdicaoDto.Telefone;

                _context.Update(cliente);
                await _context.SaveChangesAsync();

                resposta.Dados = await _context.Clientes.ToListAsync();
                resposta.Mensagem = "Cliente Editado com sucesso";

                return resposta;


            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }
        public async Task<ResponseModel<List<ClienteModel>>> ExcluirCliente(int idCliente)
        {
            ResponseModel<List<ClienteModel>> resposta = new ResponseModel<List<ClienteModel>>();
            try
            {

                var cliente = await _context.Clientes.FirstOrDefaultAsync(clienteBanco => clienteBanco.Id == idCliente);

                if (cliente == null)
                {
                    resposta.Mensagem = "Nenhum cliente localizado";
                    return resposta;
                }

                _context.Remove(cliente);
                await _context.SaveChangesAsync();

                resposta.Dados = await _context.Clientes.ToListAsync();
                resposta.Mensagem = "Cliente removido com sucesso";

                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }

        public async Task<ResponseModel<List<ClienteModel>>> ListarClientes()
        {
            ResponseModel<List<ClienteModel>> resposta = new ResponseModel<List<ClienteModel>>();
            try
            {

                var clientes = await _context.Clientes.ToListAsync();

                resposta.Dados = clientes;
                resposta.Mensagem = "Todos os clientes foram coletados";

                return resposta;

            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;

                return resposta;
            }
        }

        public async Task<ResponseModel<List<ClienteModel>>> RegistrarCliente(ClienteRegistroDto clienteRegistroDto)
        {
            ResponseModel<List<ClienteModel>> resposta = new ResponseModel<List<ClienteModel>>();
            try
            {

                var cliente = new ClienteModel()
                {
                    Name = clienteRegistroDto.Name,
                    Cpf = clienteRegistroDto.Cpf,
                    Endereco = clienteRegistroDto.Endereco,
                    Email = clienteRegistroDto.Email,
                    Telefone = clienteRegistroDto.Telefone
                };

                _context.Add(cliente);
                await _context.SaveChangesAsync();

                resposta.Dados = await _context.Clientes.ToListAsync();
                resposta.Mensagem = "Cliente registrado com sucesso!";

                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }
    }
}
