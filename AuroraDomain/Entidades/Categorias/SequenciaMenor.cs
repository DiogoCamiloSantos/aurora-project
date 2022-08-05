using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAurora.Dominio.Bases;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;

namespace ProjetoAurora.Dominio.Entidades.Categorias
{
    public class SequenciaMenor : CategoriaBase
    {
        private readonly int gPontuacao = 15;

        public SequenciaMenor()
        {

        }

        protected override int Calcular()
        {
            return this.gPontuacao;
        }

        protected override bool RolamentoValido()
        {
            int[] lValores = this.gRolamento.ObterValores();

            if (this.HaOrdemNumerica(lValores, 4) == false)
                return false;

            return true;
        }

        private bool HaOrdemNumerica(int[] prValores, int prQtValoresEmOrdem)
        {
            int lValoresEmOrdemNumerica = 1;

            for (int i = 0; i < prValores.Count() - 1; i++)
            {
                int valorAtual = prValores[i];
                int valorSucessor = prValores[i + 1];

                if (valorAtual < valorSucessor)
                {
                    lValoresEmOrdemNumerica++;

                    if (lValoresEmOrdemNumerica.Equals(prQtValoresEmOrdem))
                        return true;
                }
                else
                {
                    lValoresEmOrdemNumerica = 1;
                }
            }

            return false;
        }
    }
}