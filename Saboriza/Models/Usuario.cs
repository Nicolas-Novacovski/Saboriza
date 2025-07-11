
using System.ComponentModel.DataAnnotations.Schema;

namespace Saboriza.Models
{
    [Table("Usuarios")]
    public class Usuario : BaseModel
    {
        public Usuario()
        {
            CreatedAt = DateTime.Now;
            Status = 0;
        }

        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Senha { get; set; }
        public int Role { get; set; }
    }
}
