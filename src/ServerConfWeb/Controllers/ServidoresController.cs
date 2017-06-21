using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServerConfWeb.Data;
using ServerConfWeb.Models;
using ServerConfWeb.Models.ServidorViewModels;

namespace ServerConfAPI.Controllers
{
    [Route("api/[controller]")]
    public class ServidoresController : Controller
    {
        private ServerConfDbContext _db;

        public ServidoresController(ServerConfDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(_db.Servidores.ToList().Select(s => new ServidorViewModel(s)).ToList());
        }

        [HttpGet("{id}", Name = "GetServidorById")]
        public IActionResult GetServidorById(Guid id)
        {
            var servidor = _db.Servidores.Where(s => s.Id.Equals(id)).FirstOrDefault();

            if (servidor == null)
                return new NotFoundResult();

            return new JsonResult(new ServidorViewModel(_db.Servidores.Where(s => s.Id.Equals(id)).FirstOrDefault()));
        }

        [HttpPost]
        public IActionResult Post([FromBody]CadastrarServidorViewModel novoServidor)
        {
            var servidor = novoServidor.mapToServidor();
            _db.Servidores.Add(servidor);
            _db.SaveChanges();
            //return new CreatedAtRouteResult(nameof(GetServidorById), new { id = servidor.Id}, servidor);
            return new JsonResult(servidor);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var servidor = _db.Servidores.Where(s => s.Id.Equals(id)).FirstOrDefault();
            if (servidor != null)
            {
                _db.Remove(servidor);
                _db.SaveChanges();
            }

            return new NoContentResult();
        }
    }
}
