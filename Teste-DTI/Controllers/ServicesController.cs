using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Teste_DTI.Data;
using Teste_DTI.Migrations;
using Teste_DTI.Models;

namespace Teste_DTI.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ServicesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var services = (from s in _db.Services
                            join f in _db.Fornecedores on s.FornecedoresIdFornecedores equals f.IdFornecedores
                            select new ServicesModel
                            {
                                Id = s.Id,
                                Servico = s.Servico,
                                DescricaoServico = s.DescricaoServico,
                                PrazoEntrega = s.PrazoEntrega,
                                FornecedoresIdFornecedores = f.IdFornecedores,
                                NomeFornecedores = f.NomeFornecedores
                            }).ToList();

            return View(services);
        }

        //cadastro servico

        [HttpGet]
        public IActionResult CadastrarServico()
        {
            var service = new ServicesModel
            {
                ListaFornecedores = _db.Fornecedores.ToList()
            };
            return View(service);
        }

        [HttpPost]
        public IActionResult CadastrarServico(ServicesModel service)
        {
            if (ModelState.IsValid)
            {
                _db.Services.Add(service);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            service.ListaFornecedores = _db.Fornecedores.ToList();
            return View(service);
        }



        //deletar user
        [HttpGet]
        public IActionResult DeletarServico(int id)
        {
            {
                if (id == 0)
                {
                    return NotFound();
                }

                ServicesModel service = _db.Services.FirstOrDefault(x => x.Id == id);

                if (service == null)
                {
                    return NotFound();
                }

                return View(service);
            }

        }

        [HttpPost]
        public IActionResult DeletarServicoConfirmado(int id)
        {
            var service = _db.Services.FirstOrDefault(x => x.Id == id);

            if (service == null)
            {
                return NotFound();
            }

            _db.Services.Remove(service);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        //edit services

        [HttpGet]
        public IActionResult EditarServico(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var service = _db.Services.FirstOrDefault(x => x.Id == id);

            if (service == null)
            {
                return NotFound();
            }

            service.ListaFornecedores = _db.Fornecedores.ToList();
            return View(service);
        }

        [HttpPost]
        public IActionResult EditarServico(ServicesModel service)
        {
            if (ModelState.IsValid)
            {
                var serviceInDb = _db.Services.FirstOrDefault(x => x.Id == service.Id);

                if (serviceInDb == null)
                {
                    return NotFound();
                }

                serviceInDb.Servico = service.Servico;
                serviceInDb.DescricaoServico = service.DescricaoServico;
                serviceInDb.PrazoEntrega = service.PrazoEntrega;
                serviceInDb.FornecedoresIdFornecedores = service.FornecedoresIdFornecedores;

                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            service.ListaFornecedores = _db.Fornecedores.ToList();
            return View(service);
        }

    }

}