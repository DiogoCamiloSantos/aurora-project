using ProjetoAurora.Dominio.Interfaces.Rolamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAurora.Dominio.Entidades
{
    public class Rolamento : IRolamento
    {
        private readonly int[] ValorDados;

        public Rolamento(int[] prValorDados)
        {
            this.ValorDados = prValorDados;
        }

        public int[] ObterValores()
        {
            return this.ValorDados;
        }
    }
}
