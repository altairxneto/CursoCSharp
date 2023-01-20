using ProjetoEtiquetaProduto.Entities;
using System.Globalization;

namespace ProjetoEtiquetaProduto {
    class Program {
        public static void Main(string[] args) {
            Console.Write("Digite o número de produtos: ");
            int numeroProdutos = int.Parse(Console.ReadLine());

            List<Produto> listaProdutos = new List<Produto>();

            for(int contador = 1; contador <= numeroProdutos; contador++) {
                Console.Clear();

                Console.WriteLine($"Produto #{contador} data:");
                Console.Write("Comum, usado ou importado (c/u/i): ");
                char categoriaProduto = char.Parse(Console.ReadLine());

                if(categoriaProduto == 'c') {
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    listaProdutos.Add(new Produto(name, price));
                }

                if(categoriaProduto == 'u') {
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    listaProdutos.Add(new ProdutoUsado(name, price, date));
                }

                if(categoriaProduto == 'i') {
                    Console.Write("Nome: ");
                    string name = Console.ReadLine();

                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine());

                    listaProdutos.Add(new ProdutoImportado(name, price, customs));
                }
            }

            foreach(Produto produtos in listaProdutos) {
                Console.WriteLine(produtos.PriceTag());
            }
        }
    }
}
