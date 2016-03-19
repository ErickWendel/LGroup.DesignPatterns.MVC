using LGroup.MVC.Presentation.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


//Padrao MVC
//Existe desde 1979 SMALL TALK (XEROX)

namespace LGroup.MVC.Presentation.Controllers
{
    public class AmigoController : Controller
    {
        [HttpGet]
        public ViewResult Listar()
        {
            return View();
        }

        public ViewResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult Cadastrar(AmigoViewModel dadosTela_)
        {

            return RedirectToAction("Listar" );
        }
    }
}