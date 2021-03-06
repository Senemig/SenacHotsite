using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Hotsite.Models;
using MySql.Data.MySqlClient;
using Microsoft.AspNetCore.Diagnostics;

namespace Hotsite.Controllers
{
    public class ErroController : Controller
    {
        private readonly ILogger<ErroController> _logger;

        public ErroController(ILogger<ErroController> logger)
        {
            _logger = logger;
        }

        [Route("/erro/500")]
        public IActionResult Erro500()
        {
            //capturando a exceção que disparou a falha
            var errosOcorridos = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            string erro = @"¯\_(ツ)_/¯";
            if (errosOcorridos != null)
            {
                //mensagem da exceção disparada
                string mensagemErro = errosOcorridos.Error.Message;

                //url que o usuário acessou e gerou a exceção
                string urlErro = errosOcorridos.Path;
                erro = $"Falha: {mensagemErro} acessando {urlErro} ";
                _logger.LogError(erro);
            }
            return View("Erro", erro);
        }

        [Route("/erro/404")]
        public IActionResult Erro404()
        {
            //capturando a exceção que disparou a falha
            var errosOcorridos = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            string erro = "Erro 404";
            if (errosOcorridos != null)
            {
                //mensagem da exceção disparada
                string mensagemErro = errosOcorridos.Error.Message;

                //url que o usuário acessou e gerou a exceção
                string urlErro = errosOcorridos.Path;
                erro = $"Falha: {mensagemErro} acessando {urlErro} ";
                _logger.LogError(erro);
            }
            return View("Erro", erro);
        }
    }
}
