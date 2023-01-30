using System.Globalization;

namespace ProjetoItensVendidosManipulaArquivos.Entities
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto() { }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double ValorTotal()
        {
            return Preco * Quantidade;
        }

        public override string ToString()
        {
            return Nome + "," + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
