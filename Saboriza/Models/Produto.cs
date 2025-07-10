
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saboriza.Models
{
    [Table("Produtos")]
    public class Produto : BaseModel
    {
        public Produto()
        {
            CreatedAt = DateTime.Now;
            Status = 0;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal? PrecoPromocional { get; set; }
        public string ImagemUrl { get; set; }
        public string Categoria { get; set; }
    }
}
