﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Saboriza.Models;
using System.Collections.Generic;

namespace Saboriza.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Context _context;

        public UsuarioController(Context context)
        {
            _context = context;
        }

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

        [HttpGet]
        [Route("Cadastrar-Usuario")]
        public IActionResult Cadastro()
        {
            var model = new Usuario
            {
                Senha = $"Saboriza#{DateTime.Now.Year}"
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Cadastro(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return View(usuario);

            if (string.IsNullOrWhiteSpace(usuario.Senha))
                usuario.Senha = $"Saboriza#{DateTime.Now.Year}";

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return RedirectToAction("Cadastro"); // ou RedirectToAction("Index") se tiver uma listagem
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaUsuarios = _context.Usuarios.ToList();
            return View(listaUsuarios);
        }
    }
}
