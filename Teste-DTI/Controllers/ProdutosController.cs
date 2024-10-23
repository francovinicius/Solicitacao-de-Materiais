using Microsoft.AspNetCore.Mvc;
using Teste_DTI.Data;
using Teste_DTI.Models;

namespace Teste_DTI.Controllers
{
    public class ProdutosController : Controller
    {

        readonly private ApplicationDbContext _db;

        //buscar do banco e enviar para view
        public ProdutosController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ProdutosModel> produtos = _db.Produtos;
            return View(produtos);
        }

        //cadastro produto

        [HttpGet]
        public IActionResult CadastrarProduto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarProduto(ProdutosModel produtos)
        {
            if (ModelState.IsValid)
            {
                _db.Produtos.Add(produtos);
                _db.SaveChanges();

                //retornar para Index
                return RedirectToAction("Index");
            }

            return View();

        }

        //edit user
        [HttpGet]
        public IActionResult EditarProduto(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ProdutosModel produtos = _db.Produtos.FirstOrDefault(x => x.IdProduto == id);

            if (produtos == null)
            {
                return NotFound();
            }


            return View(produtos);
        }

        [HttpPost]
        public IActionResult EditarProduto(ProdutosModel produtos)
        {
            if (ModelState.IsValid)
            {
                _db.Produtos.Update(produtos);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(produtos);
        }

        //Estoque produto
        [HttpGet]
        public IActionResult EstoqueProduto(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ProdutosModel produtos = _db.Produtos.FirstOrDefault(x => x.IdProduto == id);

            if (produtos == null)
            {
                return NotFound();
            }


            return View(produtos);
        }

        [HttpPost]
        public IActionResult EstoqueProduto(ProdutosModel produtos)
        {
            if (ModelState.IsValid)
            {
                _db.Produtos.Update(produtos);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(produtos);
        }

        //deletar produto
        [HttpGet]
        public IActionResult DeletarProduto(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            ProdutosModel produtos = _db.Produtos.FirstOrDefault(x => x.IdProduto == id);

            if (produtos == null)
            {
                return NotFound();
            }

            return View(produtos);
        }

        [HttpPost]
        public IActionResult DeletarProduto(ProdutosModel produtos)
        {
            if (produtos == null)
            {
                return NotFound();
            }

            _db.Produtos.Remove(produtos);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
