using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoAurora.Apresentacao.Models
{
    public class RolamentoModel
    {
        [Required(ErrorMessage = "Valor deve ser definido.")]
        [Range(1, 6, ErrorMessage = "Valor deve ser definido entre 1 e 6.")]
        public int Dado1 { get; set; }

        [Required(ErrorMessage = "Valor deve ser definido.")]
        [Range(1, 6, ErrorMessage = "Valor deve ser definido entre 1 e 6.")]
        public int Dado2 { get; set; }

        [Required(ErrorMessage = "Valor deve ser definido.")]
        [Range(1, 6, ErrorMessage = "Valor deve ser definido entre 1 e 6.")]
        public int Dado3 { get; set; }

        [Required(ErrorMessage = "Valor deve ser definido.")]
        [Range(1, 6, ErrorMessage = "Valor deve ser definido entre 1 e 6.")]
        public int Dado4 { get; set; }

        [Required(ErrorMessage = "Valor deve ser definido.")]
        [Range(1, 6, ErrorMessage = "Valor deve ser definido entre 1 e 6.")]
        public int Dado5 { get; set; }

        public int[] ObterVetor()
        {
            return new int[] { Dado1, Dado2, Dado3, Dado4, Dado5 };
        }
    }
}