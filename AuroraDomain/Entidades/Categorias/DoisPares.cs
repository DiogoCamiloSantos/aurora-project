using ProjetoAurora.Dominio.Bases;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAurora.Dominio.Entidades.Categorias
{
    public class DoisPares : CategoriaBase
    {
        List<int> gValoresPares;

        public DoisPares()
        {
            this.gValoresPares = new List<int>();
        }
        
        protected override int Calcular()
        {
            int lPontuacao = gValoresPares.Sum() * 2;

            return lPontuacao;
        }

        protected override bool RolamentoValido()
        {
            int[] lValores = this.gRolamento.ObterValores();

            for (int i = 0; i < lValores.Count(); i++)
            {
                int valor = lValores[i];

                if (this.HaValoresIguais(lValores, valor))
                {
                    if(this.gValoresPares.Contains(valor) == false)
                        this.gValoresPares.Add(valor);
                }
            }

            if (this.gValoresPares.Count() != 2)
                return false;

            return true;
        }

        private bool HaValoresIguais(int[] prValores, int prValorComparacao)
        {
            int lQtRepeticao = prValores.Where(x => x.Equals(prValorComparacao)).Count();

            if (lQtRepeticao.Equals(2))
                return true;

            return false;        
        }
    }
}
