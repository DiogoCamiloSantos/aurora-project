using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAurora.Dominio.Bases;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;

namespace ProjetoAurora.Dominio.Entidades.Categorias
{
    public class Quadra : CategoriaBase
    {
        private int gValorRepetidoQuatroVezes;

        public Quadra()
        {
        }

        protected override int Calcular()
        {
            int lPontuacao = this.gValorRepetidoQuatroVezes * 4;

            return lPontuacao;
        }

        protected override bool RolamentoValido()
        {
            int lQtValorRepetido = 4;
            int[] lValores = gRolamento.ObterValores();

            if (this.HaValoresIguais(lValores, lQtValorRepetido) == false)
                return false;

            return true;
        }

        private bool HaValoresIguais(int[] prValores, int prQtValorRepetido)
        {
            for (int i = 0; i <= (prValores.Count() - prQtValorRepetido); i++)
            {
                int valor = prValores[i];
                int lQtRepeticao = prValores.Where(x => x.Equals(valor)).Count();

                if (lQtRepeticao.Equals(prQtValorRepetido))
                {
                    this.gValorRepetidoQuatroVezes = valor;
                    return true;
                }
            }

            return false;
        }
    }
}