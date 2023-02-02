
namespace Projeto.Services {
    class ServicoDeContrato {
        private IServicoDePagamentoOnline _servicoPagamentoOnline;

        public ServicoDeContrato() { }

        public ServicoDeContrato(IServicoDePagamentoOnline servicoPagamentoOnline) {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }
    }
}
