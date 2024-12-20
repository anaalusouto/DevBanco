using System.Text.Json.Serialization;

namespace SistemaCicloContabilDiario.Models
{
    public class AutorModel
    {   
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        [JsonIgnore]
        public ICollection<LivroModel> Livros { get; set; }

    }
}
