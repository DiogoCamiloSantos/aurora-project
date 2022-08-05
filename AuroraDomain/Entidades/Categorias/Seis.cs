using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAurora.Dominio.Bases;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;

namespace ProjetoAurora.Dominio.Entidades.Categorias
{
    public class Seis : CategoriaValorMinimoBase
    {
        public Seis()
        {
            this.gValorComparacaoBase = 6;
        }
    }
}