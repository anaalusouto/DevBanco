using APIPagamentoOnline.Data;
using APIPagamentoOnline.Domain.Core.Interface.UseCase;
using APIPagamentoOnline.Domain.Core.Models;
using APIPagamentoOnline.Infra.Mock;
using Microsoft.EntityFrameworkCore;

namespace APIPagamentoOnline.Domain.UseCase.PagamentoDebitoEmConta
{
    public class PagamentoDebitoEmContaService : IPagamentoDebitoEmConta
    {
        private readonly MockClienteService _mockClienteService;
        private readonly AppDBContext _context;

        public PagamentoDebitoEmContaService(AppDBContext context)
        {
            _mockClienteService = new MockClienteService();
            _context = context;
        }

        public async Task<ResponseModel<string>> ConfirmarPagamento(int clienteId, int valor)
        {
            var Resposta = new ResponseModel<string>();
            try
            {
                var cliente = await _mockClienteService.ObterDadosClienteAsync(clienteId);

                if (cliente == null)
                {
                    Resposta.Mensagem = "Cliente não encontrado";
                    Resposta.Status = false;
                    return Resposta;
                }

                if (cliente.NumConta != clienteId)
                {
                    Resposta.Mensagem = "Número do contrato não corresponde ao número da conta!";
                    Resposta.Status = false;
                    return Resposta;
                }

                if (cliente.Saldo < valor)
                {
                    Resposta.Mensagem = "Saldo insuficiente!";
                    Resposta.Status = false;
                    return Resposta;
                }

                cliente.Saldo -= valor;
                var pagamento = new PagamentoDebitoEmContaModel
                {
                    Valor = valor,
                    codigo = clienteId
                };

                await _context.LogPagamentoDebito.AddAsync( pagamento );
                await _context.SaveChangesAsync();

                Resposta.Mensagem = "Pagamento confirmado com sucesso!";
                Resposta.Dados = $"Pagamento no valor de R$ {valor} foi debitado com sucesso!";
                return Resposta;

            }
            catch (Exception ex)
            {

                Resposta.Mensagem = ex.Message;
                Resposta.Status = false;
                return Resposta;
            }
            throw new NotImplementedException();
        }

        public async Task<ResponseModel<List<PagamentoDebitoEmContaModel>>> ListarPagamentos()
        {
            var Resposta = new ResponseModel<List<PagamentoDebitoEmContaModel>>();

            try
            {
                var pagamentos = await _context.LogPagamentoDebito.ToListAsync();
                Resposta.Dados = pagamentos;
                Resposta.Mensagem = "Todos os pagamentos foram encontrados!";
                return Resposta;
            }
            catch (Exception ex)
            {
                Resposta.Mensagem = ex.Message;
                Resposta.Status = false;
                return Resposta;
            }
        }
    }
}
