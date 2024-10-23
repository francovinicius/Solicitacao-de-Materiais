using Microsoft.AspNetCore.Mvc;
using Teste_DTI.Models;
using System.Collections.Generic;

namespace Teste_DTI.Controllers
{
    public class SolicitacaoMaterialController : Controller
    {
        //simulando db
        private static List<SolicitacaoMaterialModel> solicitacoes = new List<SolicitacaoMaterialModel>
        {
            new SolicitacaoMaterialModel
            {
                IdSolicitacao = 1,
                IdProduto = 101,
                NomeProduto = "Teclado",
                Fabricante = "Logitech",
                Quantidade = 10,
                Departamento = "TI",
                Usuario = "João"
            },
            new SolicitacaoMaterialModel
            {
                IdSolicitacao = 2,
                IdProduto = 102,
                NomeProduto = "Mouse",
                Fabricante = "Razer",
                Quantidade = 5,
                Departamento = "Design",
                Usuario = "Ana"
            }
        };

        
        public IActionResult Index()
        {
            return View(solicitacoes);  
        }

       
        public IActionResult DetalheMaterial(int id)
        {
            var solicitacao = solicitacoes.Find(s => s.IdSolicitacao == id);
            if (solicitacao == null) return NotFound();

            return View(solicitacao);  
        }
    }
}
