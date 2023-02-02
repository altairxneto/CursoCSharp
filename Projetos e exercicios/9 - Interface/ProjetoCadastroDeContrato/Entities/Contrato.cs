
using System.Text;

namespace Projeto.Entities {
    class Contrato {
        public int Numero { get; private set; }
        public DateTime DataDoContrato { get; private set; }
        public double ValorTotal { get; private set; }
        public List<Prestacao> prestacoes = new List<Prestacao>();

        public Contrato() { }

        public Contrato(int numero, DateTime dataDoContrato, double valorTotal) {
            Numero = numero;
            DataDoContrato = dataDoContrato;
            ValorTotal = valorTotal;
        }

    }
}
