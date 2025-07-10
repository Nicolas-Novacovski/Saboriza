using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Saboriza.Models
{

    [table("Usuarios")]
    public class Usuario : BaseModel { 

        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public int Role { get; set; }


    }

}
