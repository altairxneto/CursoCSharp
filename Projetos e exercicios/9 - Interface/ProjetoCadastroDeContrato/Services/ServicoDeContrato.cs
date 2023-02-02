using Projeto.Entities;

namespace Projeto.Services {
    class ServicoDeContrato {
        private IServicoDePagamentoOnline _servicoPagamentoOnline;

        public ServicoDeContrato() { }

        public ServicoDeContrato(IServicoDePagamentoOnline servicoPagamentoOnline) {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        public void ProcessamentoContrato(Contrato contrato, int meses) {
            for(int contador = 1; contador <= meses; contador++) {
                DateTime dataVencimento = contrato.DataDoContrato.AddMonths(contador);

                double valorDaPrestacao = contrato.ValorTotal / meses;

                Prestacao prestacao = new Prestacao(dataVencimento, _servicoPagamentoOnline.TaxaDePagamento(_servicoPagamentoOnline.JurosDePagamento(valorDaPrestacao, contador)));

                contrato.prestacoes.Add(prestacao);
            }
        }
    }
}
