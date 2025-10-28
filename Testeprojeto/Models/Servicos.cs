using System.ComponentModel.DataAnnotations;

namespace Testeprojeto.Models
{
    public class Servicos
    {
        [Key]
        public Guid ServicosId { get; set; }

        public string Nome { get; set; }

        public string Descricao{ get; set; }

        public string Categoria { get; set; }

        public string Cliente { get; set; }   

        public string Status { get; set; }
    }
}
