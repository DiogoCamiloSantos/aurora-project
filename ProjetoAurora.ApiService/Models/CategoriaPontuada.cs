using Newtonsoft.Json;
using ProjetoAurora.Dominio.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAurora.ApiService.Models
{
    public class CategoriaPontuada
    {
        public CategoriaEnum CategoriaPontuadaEnum { get; set; }
        public string NomeCategoria { get; set; }
        public int Pontos { get; set; }
    }
}