using Microsoft.AspNetCore.Mvc;
using Saboriza.Models;
using System.Collections.Generic;

namespace Saboriza.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var produtos = new List<Produto>
            {
                new Produto { Id = 1, Nome = "Bolo de Chocolate", Descricao = "Delicioso e caseiro", Preco = 25.50M, ImagemUrl = "/img/bolo.jpg" },
                new Produto { Id = 2, Nome = "Pudim", Descricao = "Tradicional e cremoso", Preco = 15.00M, ImagemUrl = "/img/pudim.jpg" }
            };

            return View(produtos);
        }
    }
}
