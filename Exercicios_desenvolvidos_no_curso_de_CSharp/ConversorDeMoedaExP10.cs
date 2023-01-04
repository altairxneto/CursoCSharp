namespace ExercicioProposto {
    public static class ConversorDeMoedaExP10 {
        public static double Iof = 6.0;

        public static double ConversorDeMoeda(double cotacaoDolar, double valorDolar) {
            return ((valorDolar*cotacaoDolar) * Iof/100) + valorDolar * cotacaoDolar;
        }
    }
}
