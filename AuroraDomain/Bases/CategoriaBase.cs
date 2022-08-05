using ProjetoAurora.Dominio.Entidades;
using ProjetoAurora.Dominio.Interfaces.Categorias;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAurora.Dominio.Bases
{
    public abstract class CategoriaBase : ICategoria
    {
        public CategoriaBase()
        {

        }

        protected IRolamento gRolamento { get; set; }
        
        abstract protected bool RolamentoValido();
        abstract protected int Calcular();

        public void DefinirRolamento(IRolamento prRolamento)
        {
            this.gRolamento = prRolamento;
        }        

        public int ObterPontuacao()
        {
            if (this.RolamentoValido() == false)
                return 0;

            var lPontuacao = this.Calcular();

            return lPontuacao;
        }
    }
}
