using SistemaCicloContabilDiario.Domain.ValueObjects;

namespace SistemaCicloContabilDiario.Domain.Entities
{
    public class Transacao
    {
        public int TransacaoId { get; set; }
        public TipoTransacao Enum_TipoTransacao { get; set; }
        public CategoriaTransacao categoriaTransacao { get; set; }
        public Montante Montante { get; set; }
        public DateTime? Date { get; set; }
        public string Descricao { get; set; }
        public int IdContaOrigem { get; set; }

        public int IdContaDestino { get; set; }

    }
}
