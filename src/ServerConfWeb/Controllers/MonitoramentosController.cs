using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServerConfWeb.Data;
using ServerConfWeb.Models.MonitoramentoViewModels;

namespace ServerConfWeb.Controllers
{
    public class MonitoramentosController : Controller
    {
        private Data.ServerConfDbContext _db;

        public MonitoramentosController(ServerConfDbContext db)
        {
            _db = db;
        }

        // GET: Default
        public ActionResult Index()
        {
            var itens = _db.Monitoramentos.Include(m => m.Servidor).OrderByDescending(m => m.DataHora)
                .ToList();
            return View(itens);
        }
    }
}