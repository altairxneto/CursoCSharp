
namespace ProjetoContribuintesDeImpostos.Entities {
    class PessoaFisica:Contribuintes {
        public double GastosSaude { get; set; }

        public PessoaFisica() { }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude):base(nome, rendaAnual) {
            GastosSaude = gastosSaude;
        }

        public override double ImpostoPago() {
            double impostos = 0;
            if(RendaAnual < 20000) {
                impostos = RendaAnual * 15 / 100;
            }
            else if(RendaAnual < 20000 && GastosSaude != 0) {
                impostos = (RendaAnual * 15 / 100) - (GastosSaude/2);
            }
            else if (RendaAnual > 20000) {
                impostos = RendaAnual * 25 / 100;
            }
            else if (RendaAnual > 20000 && GastosSaude != 0) {
                impostos = (RendaAnual * 25 / 100) - (GastosSaude / 2);
            }

            return impostos;
        }
    }
}
