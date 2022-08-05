using ProjetoAurora.ApiService.Models;
using ProjetoAurora.Dominio.Common.Enums;
using ProjetoAurora.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAurora.Teste
{
    public class MockRolamento
    {
        public Dictionary<Rolamento, List<CategoriaPontuada>> CombinacoesDeResultado { get; set; }

        public MockRolamento()
        {
            this.CombinacoesDeResultado = new Dictionary<Rolamento, List<CategoriaPontuada>>();

            Rolamento rolamento = new Rolamento(new int[] { 2, 2, 3, 3, 3 });
            List<CategoriaPontuada> list = new List<CategoriaPontuada>();
            list.Add(new CategoriaPontuada() { CategoriaPontuadaEnum = CategoriaEnum.Dois, Pontos = 4 });
            list.Add(new CategoriaPontuada() { CategoriaPontuadaEnum = CategoriaEnum.Tres, Pontos = 9 });
            list.Add(new CategoriaPontuada() { CategoriaPontuadaEnum = CategoriaEnum.Trio, Pontos = 9 });
            list.Add(new CategoriaPontuada() { CategoriaPontuadaEnum = CategoriaEnum.Par, Pontos = 4 });
            list.Add(new CategoriaPontuada() { CategoriaPontuadaEnum = CategoriaEnum.FullHouse, Pontos = 13 });

            this.CombinacoesDeResultado.Add(rolamento, list);

            rolamento = new Rolamento(new int[] { 2, 3, 4, 5, 5 });
            list = new List<CategoriaPontuada>();
            list.Add(new CategoriaPontuada() { CategoriaPontuadaEnum = CategoriaEnum.Dois, Pontos = 2 });
            list.Add(new CategoriaPontuada() { CategoriaPontuadaEnum = CategoriaEnum.Tres, Pontos = 3 });
            list.Add(new CategoriaPontuada() { CategoriaPontuadaEnum = CategoriaEnum.Quatros, Pontos = 4 });
            list.Add(new CategoriaPontuada() { CategoriaPontuadaEnum = CategoriaEnum.Cincos, Pontos = 10 });
            list.Add(new CategoriaPontuada() { CategoriaPontuadaEnum = CategoriaEnum.Par, Pontos = 10 });
            list.Add(new CategoriaPontuada() { CategoriaPontuadaEnum = CategoriaEnum.SequenciaMenor, Pontos = 15 });

            this.CombinacoesDeResultado.Add(rolamento, list);
        }
    }
}
