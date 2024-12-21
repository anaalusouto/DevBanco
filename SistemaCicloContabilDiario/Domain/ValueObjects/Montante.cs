using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaCicloContabilDiario.Domain.ValueObjects
{
    public class Montante
    {
        public int MontanteId { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorMontante { get; set; }
        public string MoedaIso;
    }
}
