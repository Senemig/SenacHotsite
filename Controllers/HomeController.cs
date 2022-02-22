using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;
using MySql.Data.MySqlClient;

namespace Hotsite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Erro(string erro)
        {
            ViewData["Erro"] = erro;
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Interesse cad)
        {
            DatabaseService dbs = new DatabaseService();
            try
            {
                dbs.CadastraInteresse(cad);
            }
            catch (MySqlException m)
            {
                _logger.LogError(m.Message);
                return RedirectToAction("Erro");
            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao cadastrar o item: " + e.Message);
                return RedirectToAction("Erro");
            }

            ModelState.Clear();
            ViewData["Mensagem"] = "Cadastrado com sucesso!";
            return View("Index");
        }

    }
}
