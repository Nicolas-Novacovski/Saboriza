using Microsoft.AspNetCore.Http.HttpResults;
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
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string Categoria { get; set; }
    }
}
