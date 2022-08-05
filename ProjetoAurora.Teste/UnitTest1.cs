using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoAurora.ApiService.Services;

namespace ProjetoAurora.Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PontuacaoDoServicoCorreta()
        {
            PontuacaoService service = new PontuacaoService();
            MockRolamento Mock = new MockRolamento();

            var RolamentoTeste = Mock.CombinacoesDeResultado.Keys.ElementAt(1);
            var ListaCategoriaPontuadaResultado = service.ObterCategoriasPontuadas(RolamentoTeste);
            var ListacategoriaPontuacaoEsperada = Mock.CombinacoesDeResultado[RolamentoTeste];

            foreach (var item in ListaCategoriaPontuadaResultado)
            {
                var categoria = ListacategoriaPontuacaoEsperada.First(x => x.CategoriaPontuadaEnum == item.CategoriaPontuadaEnum);

                Assert.AreEqual(item.Pontos, categoria.Pontos);
            }           
        }
    }
}
