using ProjetoTratandoExcecao.Entities;
using System.Globalization;
using ProjetoTratandoExcecao.Entities.Exceptions;

namespace ProjetoTratandoExcecao {
    class Program {
        static void Main(string[] args) {

            try {
                Console.WriteLine("Digite os dados da conta.");

                Console.Write("Numero da conta: ");
                int numero = int.Parse(Console.ReadLine());

                Console.Write("Titular: ");
                string nome = Console.ReadLine();

                Console.Write("Saldo inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Limite de saque: ");
                double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Conta conta = new Conta(numero, nome, saldo, limite);

                Console.Clear();

                Console.Write("Digite a quantia para saque: ");
                double quantiaSaque = double.Parse(Console.ReadLine());

                conta.Saque(quantiaSaque);

                Console.WriteLine(conta);
            }
            catch (Excecoes ex) {
                Console.WriteLine("Erro no saque: " + ex.Message);
            }
        }
    }
}
