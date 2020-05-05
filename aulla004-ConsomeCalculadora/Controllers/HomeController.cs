using aula004_logica.calculadora;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.Mvc;

namespace aulla004_ConsomeCalculadora.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            Calculadora calc2 = new Calculadora(50,51);

            
            Calculadora calc = new Calculadora();
            
            calc.Numero1 = 2;
            calc.Numero2 = 3;

            int resulado = calc.Somar();
            
            ViewBag.Message = $"O Resultado é: {calc.Resultado}";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}