using System.Globalization;
using System.Text;

namespace Projeto.Entities {
    class Contrato {
        public int Numero { get; private set; }
        public DateTime DataDoContrato { get; private set; }
        public double ValorTotal { get; private set; }
        internal List<Prestacao> prestacoes = new List<Prestacao>();

        public Contrato() { }

        public Contrato(int numero, DateTime dataDoContrato, double valorTotal) {
            Numero = numero;
            DataDoContrato = dataDoContrato;
            ValorTotal = valorTotal;
        }

        public override string ToString() {
            StringBuilder sr = new StringBuilder();
            foreach(Prestacao prestacao in prestacoes) {
                sr.AppendLine(prestacao.DataDeVencimento.ToShortDateString() + " - " + prestacao.ValorDaPrestacao.ToString("F2", CultureInfo.InvariantCulture));
            }

            return sr.ToString();
        }
    }
}
