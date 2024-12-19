using API_Cadastro_e_Gerenciamento_de_Clientes.Domain.Core;
using API_Cadastro_e_Gerenciamento_de_Clientes.Dto.Conta;
using API_Cadastro_e_Gerenciamento_de_Clientes.Infra;
using Microsoft.EntityFrameworkCore;

namespace API_Cadastro_e_Gerenciamento_de_Clientes.Services.Conta
{
    public class ContaService : IContaInterface
    {
        private readonly AppDbContext _context;

        public ContaService(AppDbContext context)
        {
            _context = context;
        }

        // Listar todas as contas
        public async Task<ResponseModel<List<ContaModel>>> ListarContas()
        {
            ResponseModel<List<ContaModel>> resposta = new ResponseModel<List<ContaModel>>();
            try
            {
                var contas = await _context.Contas.Include(c => c.Titular).ToListAsync();

                resposta.Dados = contas;
                resposta.Mensagem = "Todas as contas foram coletadas.";

                return resposta;
            }
            catch (Exception ex)
            {
                resposta.Mensagem = ex.Message;
                resposta.Status = false;

                return resposta;
            }
        }

        // Criar uma nova conta usando ContaCriacaoDto
        public async Task<ResponseModel<ContaModel>> CriarConta(int idCliente, ContaCriacaoDto contaCriacaoDto)
        {
            ResponseModel<ContaModel> resposta = new ResponseModel<ContaModel>();
            try
            {
                // 1. Verificar se o Cliente existe
                var clienteExistente = await _context.Clientes.FindAsync(idCliente);
                if (clienteExistente == null)
                {
                    resposta.Mensagem = "Cliente não encontrado. Não foi possível criar a conta.";
                    resposta.Status = false;
                    return resposta;
                }

                // 2. Mapear os dados do DTO para o modelo ContaModel
                var novaConta = new ContaModel
                {
                    Numero = contaCriacaoDto.Numero,
                    Agencia = contaCriacaoDto.Agencia,
                    Titular = clienteExistente,
                    Saldo = contaCriacaoDto.Saldo
                };

                // 3. Adicionar a Conta no banco de dados
                await _context.Contas.AddAsync(novaConta);
                await _context.SaveChangesAsync();

                // 4. Configurar a resposta de sucesso
                resposta.Dados = novaConta;
                resposta.Mensagem = "Conta criada com sucesso!";
                resposta.Status = true;

                return resposta;
            }
            catch (Exception ex)
            {
                // Tratamento de erro
                resposta.Mensagem = $"Erro ao criar a conta: {ex.Message}";
                resposta.Status = false;

                return resposta;
            }
        }
    }
}
