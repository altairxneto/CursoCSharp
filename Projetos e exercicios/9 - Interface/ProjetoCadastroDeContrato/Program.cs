using Projeto.Entities;
using Projeto.Services;
using System.Globalization;

namespace Projeto {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o número do contrato: ");
            int numeroContrato = int.Parse(Console.ReadLine());

            Console.Write("Digite a data do contrato (dd/MM/yyyy): ");
            string data = Console.ReadLine();
            DateTime dataDoContrato = DateTime.Parse(data);

            Console.Write("Digite o valor total do contrato: ");
            double valorTotal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contrato contrato = new Contrato(numeroContrato, dataDoContrato, valorTotal);

            Console.Write("Digite o número de prestações: ");
            int numeroPrestacao = int.Parse(Console.ReadLine());

            ServicoDeContrato servico = new ServicoDeContrato(new PagamentoPaypal());

            servico.ProcessamentoContrato(contrato, numeroPrestacao);

            Console.WriteLine("Prestações:");
            Console.WriteLine(contrato);
        }
    }
}