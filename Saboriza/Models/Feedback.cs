
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saboriza.Models
{
    [Table("Feedbacks")]
    public class Feedback : BaseModel
    {
        public Feedback()
        {
            CreatedAt = DateTime.Now;
        }

        public int IdProduto { get; set; }
        public int IdUsuario { get; set; }
        public int Rating { get; set; }
        public string Avaliacao { get; set; }
    }
}
