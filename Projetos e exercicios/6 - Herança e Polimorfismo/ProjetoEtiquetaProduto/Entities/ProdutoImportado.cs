using System.Globalization;

namespace ProjetoEtiquetaProduto.Entities {
    class ProdutoImportado : Produto {
        public double CustomsFee { get; set; }

        public ProdutoImportado() { }
        
        public ProdutoImportado(string name, double price, double customsFee):base(name, price) {
            CustomsFee = customsFee;
        }

        public override string PriceTag() {
            return Name + " $ " + (Price+CustomsFee).ToString("F2", CultureInfo.InvariantCulture) + " (Customs fee: $ " + CustomsFee + ")";
        }
    }
}
