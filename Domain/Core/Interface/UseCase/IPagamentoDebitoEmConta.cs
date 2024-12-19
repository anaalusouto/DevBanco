using APIPagamentoOnline.Domain.Core.Models;

namespace APIPagamentoOnline.Domain.Core.Interface.UseCase
{
    public interface IPagamentoDebitoEmConta
    {
        Task<ResponseModel<List<PagamentoDebitoEmContaModel>>> ListarPagamentos();
        Task<ResponseModel<string>> ConfirmarPagamento(int clienteId, int valor);
    }
}
