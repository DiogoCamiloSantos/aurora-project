using ProjetoAurora.Apresentacao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAurora.Apresentacao.ViewModels
{
    public class HomeViewModel
    {
        public RolamentoModel Rolamento { get; set; }
        public List<CategoriaPontuadaModel> CategoriaPontuada { get; set; }

        public HomeViewModel()
        {
           
        }
    }
}