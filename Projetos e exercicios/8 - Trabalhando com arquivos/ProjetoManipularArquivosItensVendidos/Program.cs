using System;
using System.Globalization;
using Projeto.Entities;

namespace Projeto {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Digite o path que está seu arquivo:");
                string pathOrigem = Console.ReadLine();

                string pathDestino = Path.GetDirectoryName(pathOrigem) + @"\out\summary.csv";


            }
            catch(IOException excecao) {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(excecao.Message);
            }



        }
    }
}