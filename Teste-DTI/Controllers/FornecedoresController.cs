using Microsoft.AspNetCore.Mvc;
using Teste_DTI.Data;
using Teste_DTI.Models;

namespace Teste_DTI.Controllers
{
    public class FornecedoresController : Controller
    {

        readonly private ApplicationDbContext _db;

        //buscar do banco e enviar para view
        public FornecedoresController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<FornecedoresModel> fornecedores = _db.Fornecedores;
            return View(fornecedores);
        }

        //cadastro fornecedor

        [HttpGet]
        public IActionResult CadastrarFornecedor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarFornecedor(FornecedoresModel fornecedores)
        {
            if (ModelState.IsValid)
            {
                _db.Fornecedores.Add(fornecedores);
                _db.SaveChanges();

                //retornar para Index
                return RedirectToAction("Index");
            }

            return View();

        }

        //edit fornecedor
        [HttpGet]
        public IActionResult EditarFornecedor(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            FornecedoresModel fornecedores = _db.Fornecedores.FirstOrDefault(x => x.IdFornecedores == id);

            if (fornecedores == null)
            {
                return NotFound();
            }


            return View(fornecedores);
        }

        [HttpPost]
        public IActionResult EditarFornecedor(FornecedoresModel fornecedores)
        {
            if (ModelState.IsValid)
            {
                _db.Fornecedores.Update(fornecedores);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(fornecedores);
        }

        //deletar fornecedor
        [HttpGet]
        public IActionResult DeletarFornecedor(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            FornecedoresModel fornecedores = _db.Fornecedores.FirstOrDefault(x => x.IdFornecedores == id);

            if (fornecedores == null)
            {
                return NotFound();
            }

            return View(fornecedores);
        }

        [HttpPost]
        public IActionResult DeletarFornecedor(FornecedoresModel fornecedores)
        {
            if (fornecedores == null)
            {
                return NotFound();
            }

            _db.Fornecedores.Remove(fornecedores);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
