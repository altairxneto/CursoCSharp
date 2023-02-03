
namespace Projeto.Services {
    class ServicoPagamentoPaypal : IServicoDePagamentoOnline {
        public double JurosDePagamento(double valor, int mes) {
            return valor + valor * 0.01 * mes;
        }
        public double TaxaDePagamento(double valor) {
            return valor + (valor * 0.02);
        }
    }
}
