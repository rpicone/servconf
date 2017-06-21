using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ServerConfWeb.Data;
using ServerConfWeb.Models.MonitoramentoViewModels;

namespace ServerConfAPI.Controllers
{
    [Route("api/monitoramentos")]
    public class MonitoramentosAPIController : Controller
    {
        private ServerConfDbContext _db;

        public MonitoramentosAPIController(ServerConfDbContext db)
        {
            _db = db;
        }

        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Get()
        {
            return new JsonResult(_db.Monitoramentos.ToList().Select(s => new MonitoramentoViewModel(s)).ToList());
        }

        [HttpGet("{id}", Name = "GetMonitoramentoById")]
        public ActionResult GetMonitoramentoById(Guid id)
        {
            var servidor = _db.Monitoramentos.Where(s => s.Id.Equals(id)).FirstOrDefault();

            if (servidor == null)
                return new NotFoundResult();

            return new JsonResult(new MonitoramentoViewModel(_db.Monitoramentos.Where(s => s.Id.Equals(id)).FirstOrDefault()));
        }

        [HttpPost]
        public ActionResult Post([FromBody]CadastrarMonitoramentoViewModel novoMonitoramento)
        {
            var monitoramento = novoMonitoramento.mapToMonitoramento();
            monitoramento.DataHora = DateTime.Now;
            _db.Monitoramentos.Add(monitoramento);
            _db.SaveChanges();
            //return new CreatedAtRouteResult(nameof(GetMonitoramentoById), new { id = monitoramento.Id }, monitoramento);
            return new JsonResult(monitoramento);
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            var monitoramento = _db.Monitoramentos.Where(s => s.Id.Equals(id)).FirstOrDefault();
            if (monitoramento != null)
            {
                _db.Remove(monitoramento);
                _db.SaveChanges();
            }

            return new NoContentResult();
        }
    }
}
