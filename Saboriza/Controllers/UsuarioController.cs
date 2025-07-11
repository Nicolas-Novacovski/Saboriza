using Microsoft.AspNetCore.Mvc;
using Saboriza.Models;

namespace Saboriza.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult PerfilUsuario()
        {
            var user = new Usuario
            {
                NomeUsuario = "João Silva",
                Email = "joao@saboriza.com",
                Telefone = "(11) 98765-4321",
            };

            return View(user);
        }
    }
}

