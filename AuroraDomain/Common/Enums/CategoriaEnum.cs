using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAurora.Dominio.Common.Enums
{
    public enum CategoriaEnum
    {
        [Description("Uns")]
        Uns = 1,
        [Description("Dois")]
        Dois = 2,
        [Description("Três")]
        Tres = 3,
        [Description("Quatros")]
        Quatros = 4,
        [Description("Cincos")]
        Cincos = 5,
        [Description("Seis")]
        Seis = 6,
        [Description("Par")]
        Par = 7,
        [Description("Dois Pares")]
        DoisPares = 8,
        [Description("Trio")]
        Trio = 9,
        [Description("Quadra")]
        Quadra = 10,
        [Description("Sequência Menor")]
        SequenciaMenor = 11,
        [Description("Sequência Maior")]
        SequenciaMaior = 12,
        [Description("Full House")]
        FullHouse = 13,
        [Description("Aurora")]
        Aurora = 14
    }    
}
