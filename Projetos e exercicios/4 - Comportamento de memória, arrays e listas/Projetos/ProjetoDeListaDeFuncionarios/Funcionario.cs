using System.Globalization;
using System.Transactions;

namespace Projetos {
    public class Funcionario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int idFuncionario, string nomeFuncionario, double salarioFuncionario) {
            Id = idFuncionario;
            Nome = nomeFuncionario;
            Salario = salarioFuncionario;
        }

        public void AumentarSalario(double porcentagem) {
            Salario = Salario + (Salario * porcentagem / 100);
        }

        public override string ToString() {
            return Id+", "+Nome+", "+Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
