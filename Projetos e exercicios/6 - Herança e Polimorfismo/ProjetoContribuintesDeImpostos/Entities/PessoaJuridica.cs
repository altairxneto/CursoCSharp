
namespace ProjetoContribuintesDeImpostos.Entities {
    class PessoaJuridica:Contribuintes {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica() { }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual) {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double ImpostoPago() {
            double impostos = 0;

            if(NumeroFuncionarios > 10) {
                impostos = RendaAnual * 14 / 100;
            }
            else {
                impostos = RendaAnual * 16 / 100;
            }

            return impostos;
        }
    }
}
