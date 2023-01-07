using System.Globalization;

namespace ExercicioFixacao {
    class ContaBancariaExF4 {
        private double _saldoConta;
        private int _numeroConta;
        public string NomeTitular;

        public ContaBancariaExF4(string nomePessoa, int numeroDaConta) {
            NomeTitular = nomePessoa;
            _numeroConta = numeroDaConta;
        }

        public void Deposito(double valor) {
            _saldoConta += valor;
        }

        public void Saque(double valor) {
            _saldoConta = _saldoConta - valor - 5;
        }

        public override string ToString() {
            return "Conta " + _numeroConta + ", Titular: " + NomeTitular + ", Saldo: $" + _saldoConta.ToString("F2", CultureInfo.InvariantCulture) + " reais";
        }
    }
}
