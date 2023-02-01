namespace Projeto.Services {
    interface IServicoDePagamentoOnline {
        double TaxaDePagamento(double valor);
        double JurosDePagamento(double valor, int meses);
    }
}
