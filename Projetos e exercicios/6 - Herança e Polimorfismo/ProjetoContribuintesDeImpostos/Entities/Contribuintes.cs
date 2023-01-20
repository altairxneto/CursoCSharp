
namespace ProjetoContribuintesDeImpostos.Entities {
    abstract class Contribuintes {
        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        public Contribuintes() {
        }

        protected Contribuintes(string nome, double rendaAnual) {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double ImpostoPago();
    }
}
