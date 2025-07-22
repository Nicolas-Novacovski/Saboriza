using Saboriza.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Saboriza.DAOs
{
    public class ProdutoDAO
    {
        private readonly Context _context;

        public ProdutoDAO(Context context)
        {
            _context = context;
        }

        public List<Produto> ListarTodos()
        {
            return _context.Produtos.ToList();
        }

        //public List<Produto> ListarTodos()
        //{
        //    return _context.Produtos
        //        .Where(p => p.Status == 0)
        //        .OrderBy(p => p.Nome)
        //        .ToList();
        //}

        public Produto BuscarPorId(int id)
        {
            return _context.Produtos.FirstOrDefault(p => p.Id == id && p.Status == 0);
        }

        public void Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Atualizar(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }

        public void Remover(int id)
        {
            var produto = BuscarPorId(id);
            if (produto != null)
            {
                produto.Status = 1; // Lógica de exclusão lógica
                _context.SaveChanges();
            }
        }
    }
}
