using System.Globalization;

namespace ProjetoEtiquetaProduto.Entities {
    class ProdutoUsado:Produto{
        public DateTime DataFabricado { get; set; }

        public ProdutoUsado() { }

        public ProdutoUsado(string name, double price, DateTime dataFabricado):base(name, price) {
            DataFabricado = dataFabricado;
        }

        public override string PriceTag() {
            return Name + " (used) $ " + Price.ToString("F2", CultureInfo.InvariantCulture) + " (Manufacture date: " + DataFabricado.ToShortDateString() + ")";
        }
    }
}
