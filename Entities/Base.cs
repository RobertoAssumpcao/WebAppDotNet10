using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Base : Notifica
    {
        [Display(Name = "Código")]
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
