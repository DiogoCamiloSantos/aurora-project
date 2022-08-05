
using ProjetoAurora.Dominio.Entidades.Categorias;
using ProjetoAurora.Dominio.Interfaces.Categorias;
using ProjetoAurora.Dominio.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAurora.Dominio.Common.Factories
{
    public class CategoriaFactory
    {
        private IDictionary<CategoriaEnum, ICategoria> gListaCategorias;

        public CategoriaFactory()
        {
            this.gListaCategorias = new Dictionary<CategoriaEnum, ICategoria>();

            this.gListaCategorias.Add(CategoriaEnum.Uns, (new Uns()));
            this.gListaCategorias.Add(CategoriaEnum.Dois, (new Dois()));
            this.gListaCategorias.Add(CategoriaEnum.Tres, (new Tres()));
            this.gListaCategorias.Add(CategoriaEnum.Quatros, (new Quatros()));
            this.gListaCategorias.Add(CategoriaEnum.Cincos, (new Cincos()));
            this.gListaCategorias.Add(CategoriaEnum.Seis, (new Seis()));
            this.gListaCategorias.Add(CategoriaEnum.Par, (new Par()));
            this.gListaCategorias.Add(CategoriaEnum.DoisPares, (new DoisPares()));
            this.gListaCategorias.Add(CategoriaEnum.Trio, (new Trio()));
            this.gListaCategorias.Add(CategoriaEnum.Quadra, (new Quadra()));
            this.gListaCategorias.Add(CategoriaEnum.SequenciaMenor, (new SequenciaMenor()));
            this.gListaCategorias.Add(CategoriaEnum.SequenciaMaior, (new SequenciaMaior()));
            this.gListaCategorias.Add(CategoriaEnum.FullHouse, (new FullHouse()));
            this.gListaCategorias.Add(CategoriaEnum.Aurora, (new Aurora()));
        }

        public ICategoria MakeCategoria(CategoriaEnum prCategoriaEnum)
        {
            ICategoria lCategoria = this.gListaCategorias[prCategoriaEnum];

            return lCategoria;
        }
    }
}
