using System;
using System.Globalization;
using ProjetoCadastroDePedidos.Entities;
using ProjetoCadastroDePedidos.Entities.Enums;

namespace ProjetoCadastroDePedidos {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enter client data:");
            Console.Write("Nome: ");
            string name = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Birth date (DD/MM/YYYY): ");
            string dateBirth = Console.ReadLine();
            DateTime date = DateTime.Parse(dateBirth);

            Client cliente = new Client(name, email, date);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus os = Enum.Parse<OrderStatus>(Console.ReadLine());

            Console.Write("How many items to this order: ");
            int numOrders = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, os, cliente);

            for(int contador = 1; contador <= numOrders; contador++) {
                Console.Clear();
                Console.WriteLine($"Enter #{contador} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(productName, productPrice);

                Console.Write("Quantity: ");
                int productQuantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(productQuantity, productPrice, product);

                order.AddItem(orderItem);
            }

            Console.WriteLine(order);
        }
    }
}
