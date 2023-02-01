
namespace Projeto.Services {
    class PagamentoPaypal : IServicoDePagamentoOnline {
        public double JurosDePagamento(double valor, int meses) {
            return valor + valor * 0.01 * meses;
        }
        public double TaxaDePagamento(double valor) {
            return
        }
    }
}
