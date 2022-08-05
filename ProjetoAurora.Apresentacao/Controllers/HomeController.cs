using ProjetoAurora.Apresentacao.Common.HttpClient;
using ProjetoAurora.Apresentacao.Models;
using ProjetoAurora.Apresentacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoAurora.Apresentacao.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeViewModel prHomeViewModel = new HomeViewModel();

            return View(prHomeViewModel);
        }

        public ActionResult CalcularPontuacao(HomeViewModel prHomeViewModel)
        {
            RolamentoModel rolamentoModel = prHomeViewModel.Rolamento;

            ApiServiceClient apiServiceClient = new ApiServiceClient();
            var lCategoriasPontuadas = apiServiceClient.ObterResponse<List<CategoriaPontuadaModel>>(rolamentoModel.ObterVetor(), "http://localhost:54998/api/pontuacao", ApiServiceClient.Method.POST);

            prHomeViewModel.CategoriaPontuada = lCategoriasPontuadas;

            return View("Index", prHomeViewModel);
        }
    }
}