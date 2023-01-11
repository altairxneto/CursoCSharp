namespace Projetos {
    class Funcionario {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        /*public Funcionario(int idFuncionario) {
            Id = idFuncionario;
        }

        public Funcionario(int idFuncionario, string nomeFuncionario) : this(idFuncionario) {
            Nome = nomeFuncionario;
        }

        public Funcionario(int idFuncionario, string nomeFuncionario, double salarioFuncionario) : this(idFuncionario, nomeFuncionario) {
            Salario = salarioFuncionario;
        }
        */
    }
}
