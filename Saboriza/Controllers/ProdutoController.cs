using Microsoft.AspNetCore.Mvc;
using Saboriza.Models;
using Saboriza.DAOs;

namespace Saboriza.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        private readonly ProdutoDAO _produtoDAO;

        public ProdutoController(ProdutoDAO produtoDAO)
        {
            _produtoDAO = produtoDAO;
        }

        // GET: api/produto
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> GetProdutos()
        {
            var produtos = _produtoDAO.ListarTodos();
            return Ok(produtos);
        }

        // GET: api/produto/5
        [HttpGet("{id}")]
        public ActionResult<Produto> GetProduto(int id)
        {
            var produto = _produtoDAO.BuscarPorId(id);
            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }

        // POST: api/produto
        [HttpPost]
        public ActionResult<Produto> PostProduto(Produto produto)
        {
            _produtoDAO.Adicionar(produto);
            return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
        }

        // PUT: api/produto/5
        [HttpPut("{id}")]
        public IActionResult PutProduto(int id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            var existente = _produtoDAO.BuscarPorId(id);
            if (existente == null)
            {
                return NotFound();
            }

            _produtoDAO.Atualizar(produto);
            return NoContent();
        }

        // DELETE: api/produto/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduto(int id)
        {
            var produto = _produtoDAO.BuscarPorId(id);
            if (produto == null)
            {
                return NotFound();
            }

            _produtoDAO.Remover(id);
            return NoContent();
        }
    }
}
