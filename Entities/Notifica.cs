using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Entities
{
    public class Notifica
    {
        public Notifica()
        {
            Notificacoes = [];
        }

        [JsonIgnore] //Não aparece no swagger
        [NotMapped]
        public string? NomePropiedade { get; set; }

        [JsonIgnore] //Não aparece no swagger
        [NotMapped]
        public string? Mensagem { get; set; }

        [JsonIgnore] //Não aparece no swagger
        [NotMapped]
        public List<Notifica> Notificacoes;
    }
}
