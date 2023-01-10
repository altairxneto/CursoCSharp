using System;
using System.Globalization;

namespace Projetos {
    public class ProjetoContaBancaria {
        public static void Main() {
            double valorDeposito = 0;
            double valorDebito = 0;

            Console.WriteLine("Olá, informe os dados do cliente para que seja feito o cadastro!");

            Console.WriteLine("Entre o número da conta:");
            int numeroDaConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta:");
            string nomeTitular = Console.ReadLine();

            ContaBancaria pessoa;

            Console.WriteLine("Haverá um deposito inicial? Digite sim ou não:");
            string respostaDeposito = Console.ReadLine();

            if(respostaDeposito == "sim") {
                Console.WriteLine("Digite o valor do deposito:");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                pessoa = new ContaBancaria(numeroDaConta, nomeTitular, valorDeposito);
            }
            else {
                pessoa = new ContaBancaria(numeroDaConta, nomeTitular);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(pessoa);

            Console.WriteLine("Entre um valor para depósito:");
            valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.Deposito(valorDeposito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(pessoa);

            Console.WriteLine("Entre um valor para saque:");
            valorDebito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pessoa.Saque(valorDebito);

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(pessoa);

        }
    }
}
