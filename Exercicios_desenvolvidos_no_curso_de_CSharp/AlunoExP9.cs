using System.Globalization;

namespace ExercicioProposto {
    public class AlunoExP9 {
        public string Nome;
        public double Resultado, NotaUm, NotaDois, NotaTres;

        public double MediaFinal() {
            Resultado = NotaUm * 0.3 + NotaDois * 0.35 + NotaTres * 0.35;
            return Resultado;
        }

        public override string ToString() {
            if (MediaFinal() >= 60) {
                return "Nome: "+Nome+", Notas: "+NotaUm+", "+NotaDois+", "+NotaTres+", Nota final: "+MediaFinal().ToString("F2", CultureInfo.InvariantCulture)+". APROVADO!";
            }
            else {
                double pontosFaltantes = 60 - MediaFinal();
                return "Nome: " + Nome + ", Notas: " + NotaUm + ", " + NotaDois + ", " + NotaTres + ", Nota final: " + MediaFinal().ToString("F2", CultureInfo.InvariantCulture) + ". REPROVADO! Pontos que faltaram para ser aprovado: "+pontosFaltantes.ToString("F2");
            }
        }
    }
}
