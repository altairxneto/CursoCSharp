namespace ExercicioProposto {
    class RetanguloExP7 {
        public double Altura;
        public double Largura;

        public double AreaRetangulo() {
            return Altura * Largura;
        }

        public double PerimetroRetangulo() {
            return (2 * Altura) + (2 * Largura);
        }

        public double DiagonalRetangulo() {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }
    }
}
