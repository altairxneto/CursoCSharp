using System.Globalization;

namespace ProjetoEtiquetaProduto.Entities {
    class Produto {
        public string Name { get; set; }
        public double Price { get; set; }

        public Produto() { }

        public Produto(string name, double price) {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag() {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
