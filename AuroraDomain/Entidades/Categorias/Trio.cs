using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAurora.Dominio.Bases;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;

namespace ProjetoAurora.Dominio.Entidades.Categorias
{
    public class Trio : CategoriaBase
    {
        private int gValorRepetidoTresVezes;

        public Trio()
        {
        }

        protected override int Calcular()
        {
            int lPontuacao = this.gValorRepetidoTresVezes * 3;

            return lPontuacao;
        }

        protected override bool RolamentoValido()
        {
            int lQtValorRepetido = 3;
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
                    this.gValorRepetidoTresVezes = valor;
                    return true;
                }                    
            }

            return false;
        }
    }
}