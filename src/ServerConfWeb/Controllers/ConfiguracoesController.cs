using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ServerConfWeb.Data;
using ServerConfWeb.Models.ConfiguracaoViewModels;

namespace ServerConfAPI.Controllers
{
    [Route("api/[controller]")]
    public class ConfiguracoesController : Controller
    {
        private ServerConfDbContext _db;

        public ConfiguracoesController(ServerConfDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return new JsonResult(_db.Configuracoes.ToList().Select(s => new ConfiguracaoViewModel(s)).ToList());
        }

        [HttpGet("{id}", Name = "GetConfiguracaoById")]
        public ActionResult GetConfiguracaoById(Guid id)
        {
            var servidor = _db.Configuracoes.Where(s => s.Id.Equals(id)).FirstOrDefault();

            if (servidor == null)
                return new NotFoundResult();

            return new JsonResult(new ConfiguracaoViewModel(_db.Configuracoes.Where(s => s.Id.Equals(id)).FirstOrDefault()));
        }

        [HttpPost]
        public ActionResult Post([FromBody]CadastrarConfiguracaoViewModel novaConfiguracao)
        {
            var configuracao = novaConfiguracao.mapToConfiguracao();
            configuracao.DataHora = DateTime.Now;
            _db.Configuracoes.Add(configuracao);
            _db.SaveChanges();
            //return new CreatedAtRouteResult(nameof(GetConfiguracaoById), new { id = configuracao.Id }, configuracao);
            return new JsonResult(configuracao);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var configuracao = _db.Configuracoes.Where(s => s.Id.Equals(id)).FirstOrDefault();
            if (configuracao != null)
            {
                _db.Remove(configuracao);
                _db.SaveChanges();
            }

            return new NoContentResult();
        }
    }
}
