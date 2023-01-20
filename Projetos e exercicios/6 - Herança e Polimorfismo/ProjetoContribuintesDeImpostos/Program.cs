using ProjetoContribuintesDeImpostos.Entities;
using System.Globalization;

namespace ProjetoContribuintesDeImpostos {
    class Program {
        static void Main(string[] args) {
            List<Contribuintes> list = new List<Contribuintes>();

            Console.Write("Digite o número de contribuintes: ");
            int numeroContribuintes = int.Parse(Console.ReadLine());

            for(int contador = 1; contador <= numeroContribuintes; contador++) {
                Console.Clear();

                Console.WriteLine($"Contribuinte #{contador}:");
                Console.Write("Pessoa juridica ou física (j/f): ");
                char ch = char.Parse(Console.ReadLine());

                if(ch == 'f') {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Renda anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Gastos com saúde: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new PessoaFisica(nome, rendaAnual, gastoSaude));
                }
                else if(ch == 'j') {
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();

                    Console.Write("Renda anual: ");
                    double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Número de funcionários: ");
                    int numFuncionarios = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(nome, rendaAnual, numFuncionarios));
                }
                else {
                    Console.WriteLine("Inválido!");
                }
            }

            Console.Clear();
            Console.WriteLine("IMPOSTOS PAGOS: ");

            double totalImpostos = 0;

            foreach(Contribuintes contribuintes in list) {
                Console.WriteLine(contribuintes.Nome + ": $ " + contribuintes.ImpostoPago().ToString("F2", CultureInfo.InvariantCulture));

                totalImpostos += contribuintes.ImpostoPago();
            }

            Console.WriteLine("TOTAL DE IMPOSTOS PAGOS: $ " + totalImpostos.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
