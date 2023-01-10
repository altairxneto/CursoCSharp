using System.Globalization;

namespace Projetos {
    class ContaBancaria {
        public double SaldoConta { get; private set; }
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }

        public ContaBancaria(int numero, string nome) {
            NumeroConta = numero;
            NomeTitular = nome;
        }

        public ContaBancaria(int numero, string nome, double valorInicial):this(numero, nome) {
            Deposito(valorInicial);
        }

        public void Deposito(double valor) {
            SaldoConta += valor;
        }

        public void Saque(double valor) {
            SaldoConta = SaldoConta - valor - 5;
        }

        public override string ToString() {
            return "Conta " 
                + NumeroConta 
                + ", Titular: " 
                + NomeTitular 
                + ", Saldo: $" 
                + SaldoConta.ToString("F2", CultureInfo.InvariantCulture) 
                + " reais";
        }
    }
}
