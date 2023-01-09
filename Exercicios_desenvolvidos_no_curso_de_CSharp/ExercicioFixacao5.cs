using System;

namespace ExercicioFixacao {
    public class ExercicioF5 {
        public void ExF5() {
            Console.WriteLine("Quantos quartos serão alugados?");
            int quantidadeQuartos = int.Parse(Console.ReadLine());

            EstudanteExF5[] quarto = new EstudanteExF5[10];
            
            for(int contador = 0; contador < quantidadeQuartos; contador++) {
                Console.WriteLine("Aluguel#"+(contador+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int numeroQuarto = int.Parse(Console.ReadLine());
                quarto[numeroQuarto] = new EstudanteExF5(nome, email);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos ocupados:");

            for(int contador = 0; contador < 9; contador++) {
                if (quarto[contador] != null) {
                    Console.WriteLine(contador + ": " + quarto[contador]);
                }
            }
        }
    }
}
