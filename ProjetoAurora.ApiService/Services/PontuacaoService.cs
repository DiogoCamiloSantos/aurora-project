using PojetoAurora.Dominio.Common.Enums.Extensions;
using ProjetoAurora.ApiService.Models;
using ProjetoAurora.Dominio.Common.Enums;
using ProjetoAurora.Dominio.Common.Factories;
using ProjetoAurora.Dominio.Entidades;
using ProjetoAurora.Dominio.Interfaces.Rolamentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ProjetoAurora.ApiService.Services
{
    public class PontuacaoService
    {
        public List<CategoriaPontuada> ObterCategoriasPontuadas(IRolamento prRolamento)
        {
            IRolamento lRolamento = prRolamento;

            List<CategoriaEnum> lCategorias = this.ObterListaDeCategorias();
            List<CategoriaPontuada> lCategoriaPontuada = new List<CategoriaPontuada>();

            foreach (var categoriaEnum in lCategorias)
            {
                CategoriaFactory categoriaFactory = new CategoriaFactory();
                var categoria = categoriaFactory.MakeCategoria(categoriaEnum);

                categoria.DefinirRolamento(lRolamento);
                int pontuacao = categoria.ObterPontuacao();

                if (pontuacao > 0)
                    lCategoriaPontuada.Add((new CategoriaPontuada()
                    {
                        CategoriaPontuadaEnum = categoriaEnum,
                        NomeCategoria = categoriaEnum.GetEnumDescription(),
                        Pontos = pontuacao
                    }));
            }

            return lCategoriaPontuada;
        }

        private List<CategoriaEnum> ObterListaDeCategorias()
        {
            var lResult = Enum.GetValues(typeof(CategoriaEnum)).Cast<CategoriaEnum>().ToList();

            return lResult;
        }

        //private IRolamento DefinirRolamento(RolamentoModel prRolamentoModel)
        //{
        //    IRolamento lRolamento = new Rolamento((new int[5]
        //    {
        //        prRolamentoModel.Dado1,
        //        prRolamentoModel.Dado2,
        //        prRolamentoModel.Dado3,
        //        prRolamentoModel.Dado4,
        //        prRolamentoModel.Dado5
        //    }));

        //    return lRolamento;
        //}
    }
}