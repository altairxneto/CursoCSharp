using Projeto.Entidades;
using System.Globalization;
namespace Projeto {
    class Program {
        public static void Main() {
            Console.WriteLine("Insira o path do arquivo: ");
            string pathArquivo = Console.ReadLine() + @"\funcionarios.csv";

            Console.WriteLine("Insira o salário: ");
            double salarioFuncionarioReferencia = double.Parse(Console.ReadLine());

            string[] arrayArquivoFuncionarios = File.ReadAllLines(pathArquivo);

            List<Funcionario> funcionarios = new();
            foreach(string line in arrayArquivoFuncionarios) {
                string[] splitDaString = line.Split(",");

                funcionarios.Add(new Funcionario(splitDaString[0], splitDaString[1], double.Parse(splitDaString[2], CultureInfo.InvariantCulture)));
            }

            var emailsFuncionarios = funcionarios.Where(p => p.Salario > salarioFuncionarioReferencia).OrderBy(p => p.Email).Select(p => p.Email);

            foreach(var emailFuncionario in emailsFuncionarios) {
                Console.WriteLine(emailFuncionario.ToString());
            }

            var salarioPessoas = funcionarios.Where(p => p.Nome[0].ToString() == "M").Select(p => p.Salario).Sum();

            Console.WriteLine("Soma dos salários das pessoas que tenham o nome que começa com a letra M: R$" + salarioPessoas);
        }
    }
}