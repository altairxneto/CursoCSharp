using System.Globalization;
using System.Text;
using ProjetoTratandoExcecao.Entities.Exceptions;

namespace ProjetoTratandoExcecao.Entities {
    class Conta {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }
        public double SaqueLimite { get; set; }

        public Conta() { }

        public Conta(int numero, string titular, double saldo, double saqueLimite) {
            Numero = numero;
            Titular = titular;
            Deposito(saldo);
            SaqueLimite = saqueLimite;
        }

        public void Deposito(double quantia) {
            Saldo += quantia;
        }

        public void Saque(double quantia) {
            if(quantia > SaqueLimite) {
                throw new Excecoes("A quantia ultrapassa o limite de saque!");
            }

            if(quantia > Saldo) {
                throw new Excecoes("Saldo insuficiente para saque.");
            }

            Saldo -= quantia;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Numero da conta: " + Numero);
            sb.AppendLine("Titular: " + Titular);
            sb.AppendLine("Novo saldo: " + Saldo.ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
}
