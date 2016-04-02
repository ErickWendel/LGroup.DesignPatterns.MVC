using LGroup.MVC.Presentation.ViewModel;
using LGroup.MVC.DataTransferObject;
using LGroup.MVC.Business;
using System.Web.Mvc;
using FastMapper;
using System.Collections.Generic;
using LGroup.MVC.Business.Base;

namespace LGroup.MVC.Presentation.Controllers
{
    public sealed class AmigoController : Controller
    {
        //VIEW -> CONTROLLER -> BUSINESS -> DAL (DAO)
        private readonly IBaseBusiness<AmigoDTO> _negocio;


        //Aplicamos o padrao IoC, a classe AmigoBusiness
        //Vai vir inicializada de fora
        public AmigoController(IBaseBusiness<AmigoDTO> negocio_)
        {
            _negocio = negocio_;

        }
        //MAPEAMENTO DE CLASSES (AUTOMAPPER, VALUE INJECT, FAST MAPPER)
        //A MAIS RÁPIDO E MENOS CONHECIDA É FASTMAPPER
        [HttpGet]
        public ViewResult Listar()
        {
            var amigosLista = _negocio.Listar();
            var amigoTela = TypeAdapter.Adapt<IEnumerable<AmigoDTO>, IEnumerable<AmigoViewModel>>(amigosLista);

            return View(amigoTela);
        }

        [HttpGet]
        public ViewResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult Cadastrar(AmigoViewModel dadosTela)
        {
            var dadosTabela = TypeAdapter.Adapt<AmigoViewModel, AmigoDTO>(dadosTela);
            _negocio.Cadastrar(dadosTabela);

            return RedirectToAction("Listar");
        }
    }
}