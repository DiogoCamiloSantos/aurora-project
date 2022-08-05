using ProjetoAurora.Dominio.Bases;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;

namespace ProjetoAurora.Dominio.Entidades.Categorias
{
    public class Uns : CategoriaValorMinimoBase
    {
        public Uns()
        {
            this.gValorComparacaoBase = 1;
        }
    }
}
