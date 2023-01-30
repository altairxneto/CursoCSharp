using System.Globalization;
using System.Collections.Generic;
using ProjetoItensVendidosManipulaArquivos.Entities;

namespace Projeto
{
    class Program {
        static void Main(string[] args) {
            string pathOrigem = @"C:\Users\altai\OneDrive\Documentos\C#\Projetos\CSharp\Projetos e exercicios\8 - Trabalhando com arquivos\ItensVendidos.csv";

            Directory.CreateDirectory(@"C:\Users\altai\OneDrive\Documentos\C#\Projetos\CSharp\Projetos e exercicios\8 - Trabalhando com arquivos\out");
            string pathDestino = @"C:\Users\altai\OneDrive\Documentos\C#\Projetos\CSharp\Projetos e exercicios\8 - Trabalhando com arquivos\out\Summary.csv";

            string[] lerArquivos = File.ReadAllLines(pathOrigem);

            List<string> linhasDoArquivo = new List<string>();
            List<Produto> listaDeProdutos = new List<Produto>();

            foreach(string line in lerArquivos) {
                linhasDoArquivo.Add(line);
            }

            foreach(string line in linhasDoArquivo) {
                string[] auxiliar = new string[2];
                auxiliar = line.Split(',');

                string nome = auxiliar[0];
                double preco = double.Parse(auxiliar[1], CultureInfo.InvariantCulture);
                int quantidade = int.Parse(auxiliar[2]);

                Produto produto = new Produto(nome, preco, quantidade);
                listaDeProdutos.Add(produto);
            }

            using(StreamWriter sw = File.AppendText(pathDestino)) {
                foreach(Produto produto in listaDeProdutos) {
                    sw.WriteLine(produto);
                }
            }
            
        }
    }
}