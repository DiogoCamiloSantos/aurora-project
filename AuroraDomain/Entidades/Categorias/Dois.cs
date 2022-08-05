using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAurora.Dominio.Interfaces.Categorias;
using ProjetoAurora.Dominio.Bases;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;

namespace ProjetoAurora.Dominio.Entidades.Categorias
{
    public class Dois : CategoriaValorMinimoBase
    {
        public Dois()
        {
            this.gValorComparacaoBase = 2;
        }
    }
}
