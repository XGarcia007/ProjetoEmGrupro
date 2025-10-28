using System.ComponentModel.DataAnnotations;

namespace Testeprojeto.Models
{
    public class Contato
    {
        [Key]

        public Guid ContatoId { get; set; }
       
        public string Nome { get; set; }

        public string Celular { get; set; }

        public string Observacao { get; set; }
    }
}
