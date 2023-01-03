namespace ExercicioProposto {
    class RetanguloExP7 {
        public double altura;
        public double largura;

        public double AreaRetangulo() {
            return altura * largura;
        }

        public double PerimetroRetangulo() {
            return (2 * altura) + (2 * largura);
        }

        public double DiagonalRetangulo() {
            return Math.Sqrt(Math.Pow(altura, 2) + Math.Pow(largura, 2));
        }
    }
}
