using Microsoft.AspNetCore.Mvc;
using Teste_DTI.Data;
using Teste_DTI.Models;

namespace Teste_DTI.Controllers
{
    public class UsuariosController : Controller
    {

        readonly private ApplicationDbContext _db;

        //buscar do banco e enviar para view
        public UsuariosController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //buscando todos usuarios no banco
            IEnumerable<UsuariosModel> usuarios = _db.Usuarios;
            return View(usuarios);
        }

        //cadastro user

        [HttpGet]
        public IActionResult CadastrarUsuario() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(UsuariosModel usuarios)
        {
            if (ModelState.IsValid) {
                _db.Usuarios.Add(usuarios);
                _db.SaveChanges();

                //retornar para Index
                return RedirectToAction("Index");
            }

            return View();

        }

        //edit user
        [HttpGet]
        public IActionResult EditarUsuario(int id) 
        {
            if(id == null || id == 0) {
                return NotFound();
            }

            UsuariosModel usuarios = _db.Usuarios.FirstOrDefault(x => x.IdUsuario == id);

            if (usuarios == null) {
                return NotFound();
            }


            return View(usuarios); 
        }

        [HttpPost]
        public IActionResult EditarUsuario(UsuariosModel usuarios)
        {
            if (ModelState.IsValid)
            {
                _db.Usuarios.Update(usuarios);
                _db.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(usuarios);
        }

        //deletar user
        [HttpGet]
        public IActionResult DeletarUsuario(int id) 
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            UsuariosModel usuario = _db.Usuarios.FirstOrDefault(x => x.IdUsuario == id);
            
            if (usuario == null) 
            {
                return NotFound();
            }

            return View(usuario);
        }

        [HttpPost]
        public IActionResult DeletarUsuario(UsuariosModel usuarios)
        {
            if (usuarios == null)
            {
                return NotFound();
            }

            _db.Usuarios.Remove(usuarios);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
