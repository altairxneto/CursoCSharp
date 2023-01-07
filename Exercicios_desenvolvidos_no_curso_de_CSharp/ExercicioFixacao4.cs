using System;
using System.Globalization;

namespace ExercicioFixacao {
    public class ExercicioF4 {
        public void ExF4() {
            double valorDeposito = 0;
            double valorDebito = 0;

            Console.WriteLine("Olá, informe os dados do cliente para que seja feito o cadastro!");

            Console.WriteLine("Entre o número da conta:");
            int numConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre o titular da conta:");
            string nomeTitular = Console.ReadLine();

            ContaBancariaExF4 pessoa = new ContaBancariaExF4(nomeTitular, numConta);

            Console.WriteLine("Haverá um deposito inicial? Digite sim ou não:");
            string respostaDeposito = Console.ReadLine();

            if(respostaDeposito == "sim") {
                Console.WriteLine("Digite o valor do deposito:");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                pessoa.Deposito(valorDeposito);
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
