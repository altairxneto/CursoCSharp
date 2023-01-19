using System.Text;
using System.Globalization;

namespace ProjetoCadastroDePedidos.Entities {
    class OrderItem {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal() {
            return Quantity * Price;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            sb.Append(Product.Name);
            sb.Append(", $" + Product.Price.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(", Quantidade: " + Quantity);
            sb.Append(", Subtotal: $" + SubTotal());

            return sb.ToString();
        }
    }
}
