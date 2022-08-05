using ProjetoAurora.Dominio.Bases;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;
using System.Linq;

namespace ProjetoAurora.Dominio.Entidades.Categorias
{
    public class Aurora : CategoriaBase
    {
        private readonly int gPontuacao = 50;

        public Aurora()
        {

        }

        protected override int Calcular()
        {
            return this.gPontuacao;
        }

        protected override bool RolamentoValido()
        {
            int lValorComparacao = this.gRolamento.ObterValores()[0];
            int lQtValoresRolamento = this.gRolamento.ObterValores().Count();

            int lQtValoresIguais = this.gRolamento.ObterValores().Where(x => x.Equals(lValorComparacao)).Count();

            if (lQtValoresIguais.Equals(lQtValoresRolamento) == false)
                return false;

            return true;
        }
    }
}
