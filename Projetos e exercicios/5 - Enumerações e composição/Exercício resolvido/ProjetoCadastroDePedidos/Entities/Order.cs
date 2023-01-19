using ProjetoCadastroDePedidos.Entities.Enums;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ProjetoCadastroDePedidos.Entities {
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Itens { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order() {
        }

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            Itens.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            Itens.Remove(item);
        }

        public double Total() {
            double sumTotal = 0;
            foreach(OrderItem item in Itens) {
                sumTotal += item.SubTotal();
            }

            return sumTotal;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();

            Console.Clear();
            sb.AppendLine("ORDER SUMMARY:");
            sb.AppendLine("Order moment: " + DateTime.Now);
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine(Client.ToString());
            sb.AppendLine("Order items:");
            foreach(OrderItem item in Itens) {
                sb.AppendLine(item.ToString());
            }

            sb.Append("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }

    }
}
