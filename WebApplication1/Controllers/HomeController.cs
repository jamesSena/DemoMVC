using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("")]
    [Route("gestao")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("inicio")]
        public IActionResult Index()
        {
            var filme = new Filme
            {
                Titulo = "12",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = 10,
                Valor = 20000
            };
            return RedirectToAction("Privacy", filme);
           // return View();
        }
        [Route("Privacy")]
        [Route("Privacys")]

        public IActionResult Privacy(Filme filme)
        {
            if (!ModelState.IsValid)
            {
                foreach (var erros in ModelState.Values.SelectMany(m => m.Errors))
                {
                    Console.Write(erros.ErrorMessage);
                }
            }
            return View();
        }
        [Route("error")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
