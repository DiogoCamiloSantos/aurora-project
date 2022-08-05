using System.Linq;

namespace ProjetoAurora.Dominio.Bases
{
    public abstract class CategoriaValorMinimoBase : CategoriaBase
    {
        private int gOcorrenciaDeValor;
        protected int gValorComparacaoBase;

        public CategoriaValorMinimoBase()
        {
        }

        protected override int Calcular()
        {
            int lPontuacao = this.gOcorrenciaDeValor * gValorComparacaoBase;

            return lPontuacao;
        }

        protected override bool RolamentoValido()
        {
            int lOcorencia = this.gRolamento.ObterValores().Where(valor => valor.Equals(gValorComparacaoBase)).Count();

            if (lOcorencia == 0)
                return false;

            this.gOcorrenciaDeValor = lOcorencia;

            return true;
        }
    }
}
