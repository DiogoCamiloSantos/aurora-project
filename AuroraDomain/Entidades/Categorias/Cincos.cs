using ProjetoAurora.Dominio.Bases;
using ProjetoAurora.Dominio.Interfaces.Categorias;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAurora.Dominio.Entidades.Categorias
{
    public class Cincos : CategoriaValorMinimoBase
    {
        public Cincos()
        {
            this.gValorComparacaoBase = 5;
        }
    }
}
