using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAurora.Dominio.Bases;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;

namespace ProjetoAurora.Dominio.Entidades.Categorias
{
    public class FullHouse : CategoriaBase
    {
        private bool flagParEncontradoNoRolamento = false;
        private bool flagTrioEncontradoNoRolamento = false;

        public FullHouse()
        {
        }

        protected override int Calcular()
        {
            int lPontuacao = this.gRolamento.ObterValores().Sum();

            return lPontuacao;
        }

        protected override bool RolamentoValido()
        {
            List<int> lValoresPares = new List<int>();
            int[] lValores = this.gRolamento.ObterValores();

            for (int i = 0; i < lValores.Count(); i++)
            {
                int valor = lValores[i];

                if (this.HaValoresIguais(lValores, valor))
                {
                    if (lValoresPares.Contains(valor) == false)
                        lValoresPares.Add(valor);
                }
            }

            if (lValoresPares.Count() != 2)
                return false;

            return true;
        }

        private bool HaValoresIguais(int[] prValores, int prValorComparacao)
        {
            int lQtRepeticao = prValores.Where(x => x.Equals(prValorComparacao)).Count();

            if (lQtRepeticao.Equals(2) && this.flagParEncontradoNoRolamento == false)
            {
                this.flagParEncontradoNoRolamento = true;
                return true;
            }
               

            if (lQtRepeticao.Equals(3) && this.flagTrioEncontradoNoRolamento == false)
            {
                this.flagTrioEncontradoNoRolamento = true;
                return true;
            }

            return false;
        }
    }
}