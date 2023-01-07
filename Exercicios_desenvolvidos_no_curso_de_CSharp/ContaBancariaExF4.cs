namespace ExercicioFixacao {
    class ContaBancariaExF4 {
        private double _saldoConta;
        public string NomeTitular;
        public int NumeroConta { get; private set; }

        public void Deposito(double valor) {
            _saldoConta += valor;
        }

        public void Saque(double valor) {
            _saldoConta -= valor;
        }
    }
}
