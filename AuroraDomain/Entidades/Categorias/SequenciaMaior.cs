using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAurora.Dominio.Bases;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;

namespace ProjetoAurora.Dominio.Entidades.Categorias
{
    public class SequenciaMaior : CategoriaBase
    {
        private readonly int gPontuacao = 20;

        public SequenciaMaior()
        {
        }

        protected override int Calcular()
        {
            return this.gPontuacao;
        }

        protected override bool RolamentoValido()
        {
            int[] lValores = this.gRolamento.ObterValores();

            if (this.HaOrdemNumerica(lValores) == false)
                return false;

            return true;
        }

        private bool HaOrdemNumerica(int[] prValores)
        {
            for (int i = 0; i < prValores.Count() - 1; i++)
            {
                bool _ValoresEmOrdemNumerica = (prValores[i] < prValores[i + 1]);

                if (_ValoresEmOrdemNumerica == false)
                    return false;
            }

            return true;
        }
    }
}
