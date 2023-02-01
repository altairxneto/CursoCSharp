
namespace Projeto.Entities {
    class Prestacao {
        public DateTime DataDeVencimento { get; set; }
        public double ValorDaPrestacao { get; set; }

        public Prestacao(DateTime dataDeVencimento, double valorDaPrestacao) {
            DataDeVencimento = dataDeVencimento;
            ValorDaPrestacao = valorDaPrestacao;
        }
    }
}
