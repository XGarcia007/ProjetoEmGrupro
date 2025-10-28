using System.ComponentModel.DataAnnotations;

namespace Testeprojeto.Models
{
    public class Portfolio
    {
        [Key]
        public Guid PorfolioId { get; set; }

        public string Servicos { get; set; }

        public string Descricao { get; set; }

        public string Missao { get; set; }

        public string Valores { get; set; }

        public string Visao { get; set; }
    }
}
