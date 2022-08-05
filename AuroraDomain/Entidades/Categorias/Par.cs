using ProjetoAurora.Dominio.Bases;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAurora.Dominio.Entidades.Categorias
{
    public class Par : CategoriaBase
    {
        private int gValorRepetido = 0;

        public Par()
        {

        }

        protected override int Calcular()
        {
            int lPontuacao = this.gValorRepetido * 2;

            return lPontuacao;
        }

        protected override bool RolamentoValido()
        {
            foreach (int _value in this.gRolamento.ObterValores())
            {
                int lQtRepeticao = this.gRolamento.ObterValores().Where(x => x == _value).Count();

                if (lQtRepeticao == 2)
                {
                    if(_value > this.gValorRepetido)
                        this.gValorRepetido = _value;
                }
            }

            if(this.gValorRepetido > 0)
                return true;

            return false;
        }
    }
}
