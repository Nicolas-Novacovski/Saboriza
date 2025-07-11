using Microsoft.AspNetCore.Mvc;
using Saboriza.Models;

namespace Saboriza.Controllers
{
    public class UsuarioController : Controller
    {
        [HttpGet]
        [Route("Perfil-Usuario")]
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

        [HttpGet]
        [Route("Prato-Favorito")]
        public IActionResult PratoFavorito()
        {
            var favoritos = new List<PratoFavorito>
    {
        new PratoFavorito
        {
            Id = 1,
            Nome = "Pizza Margherita",
            DescricaoCurta = "Molho de tomate, mussarela e manjericão fresco.",
            ImagemUrl = "/imagens/pizza-margherita.jpg"
        },
        new PratoFavorito
        {
            Id = 2,
            Nome = "Sushi de Salmão",
            DescricaoCurta = "Fresco, delicado e saboroso.",
            ImagemUrl = "/imagens/sushi-salmao.jpg"
        },
        new PratoFavorito
        {
            Id = 3,
            Nome = "Tacos de Carne",
            DescricaoCurta = "Carne bem temperada e molho picante.",
            ImagemUrl = "/imagens/tacos-carne.jpg"
        }
    };

            return View(favoritos);
        }


        public IActionResult Cadastro()
        {
            return View();
        }
    }

}

