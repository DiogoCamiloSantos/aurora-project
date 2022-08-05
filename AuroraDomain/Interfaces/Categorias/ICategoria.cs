using ProjetoAurora.Dominio.Entidades;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAurora.Dominio.Interfaces.Categorias
{
    public interface ICategoria
    {
        void DefinirRolamento(IRolamento prRolamento);
        int ObterPontuacao();
    }
}
