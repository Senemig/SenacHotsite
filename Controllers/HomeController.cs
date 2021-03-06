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

        public IActionResult Index()
        {
            return View();
        }

        // [HttpPost]
        // public IActionResult Cadastrar(Interesse cad)
        // {
        //     DatabaseService dbs = new DatabaseService();
        //     try
        //     {
        //         dbs.CadastraInteresse(cad);
        //         ModelState.Clear();
        //         ViewData["Mensagem"] = "Cadastrado com sucesso!";
        //     }
        //     catch (MySqlException m)
        //     {
        //         _logger.LogError(m.Message);
        //         return View("Erro", m.Message);
        //     }
        //     catch (Exception e)
        //     {
        //         _logger.LogError("Erro ao cadastrar o item: " + e.Message);
        //         return View("Erro", "Erro ao cadastrar o item: " + e.Message);
        //     }


        //     return View("Index");
        // }

        [HttpPost]
        public string Cadastrar(Interesse cad)
        {
            DatabaseService dbs = new DatabaseService();
            try
            {
                dbs.CadastraInteresse(cad);
                ModelState.Clear();
            }
            catch (MySqlException m)
            {
                _logger.LogError(m.Message);
                return m.Message;
            }
            catch (Exception e)
            {
                _logger.LogError("Erro ao cadastrar o item: " + e.Message);
                return "Erro ao cadastrar o item: " + e.Message;
            }
            return "OK";
        }

    }
}
