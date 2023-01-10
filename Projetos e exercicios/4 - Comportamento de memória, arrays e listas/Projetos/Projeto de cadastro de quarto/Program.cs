using System;

namespace Projetos {
    public class ProjetoCadastroQuarto {
        public static void Main() {
            Console.WriteLine("Quantos quartos serão alugados?");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            Estudante[] quarto = new Estudante[10];
            
            for(int contador = 0; contador < quantidadeQuartos; contador++) {
                Console.WriteLine("Aluguel#"+(contador+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                quarto[numeroQuarto] = new Estudante(nome, email);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");

            for(int contador = 0; contador < 10; contador++) {
                if (quarto[contador] != null) {
                    Console.WriteLine(contador + ": " + quarto[contador]);
                }
            }
        }
    }
}
