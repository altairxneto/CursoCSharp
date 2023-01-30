using System.Globalization;
using Projeto.Entities;

namespace Projeto {
    class Program {
        static void Main(string[] args) {
            try {
                Console.WriteLine("Digite o path que está seu arquivo:");
                string pathOrigem = Console.ReadLine();

                Directory.CreateDirectory(Path.GetDirectoryName(pathOrigem) + @"\out");

                string pathDestino = Path.GetDirectoryName(pathOrigem) + @"\out\summary.csv";

                string[] lerArquivos = File.ReadAllLines(pathOrigem);

                StreamWriter sr = null;

                foreach (string line in lerArquivos) {
                    string[] auxiliar = line.Split(',');

                    string nome = auxiliar[0];
                    double preco = double.Parse(auxiliar[1], CultureInfo.InvariantCulture);
                    int quantidade = int.Parse(auxiliar[2]);

                    Produto produto = new Produto(nome, preco, quantidade);

                    using(sr = File.AppendText(pathDestino)) {
                        sr.WriteLine(produto.Nome + "," + produto.ValorTotal().ToString("F2", CultureInfo.InvariantCulture));
                    }
                }
            }
            catch(IOException excecao) {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(excecao.Message);
            }



        }
    }
}