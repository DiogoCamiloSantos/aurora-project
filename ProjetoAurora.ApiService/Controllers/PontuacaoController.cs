using ProjetoAurora.ApiService.Models;
using ProjetoAurora.ApiService.Services;
using ProjetoAurora.Dominio.Entidades;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoAurora.ApiService.Controllers
{
    public class PontuacaoController : ApiController
    {
        [HttpPost]
        public List<CategoriaPontuada> ObterCategoriasPontuadas(int[] prValores)
        {
            Rolamento lRolamento = new Rolamento(prValores);

            PontuacaoService lPontuacaoService = new PontuacaoService();
            var Lista = lPontuacaoService.ObterCategoriasPontuadas(lRolamento);

            return Lista;
        }
    }
}
