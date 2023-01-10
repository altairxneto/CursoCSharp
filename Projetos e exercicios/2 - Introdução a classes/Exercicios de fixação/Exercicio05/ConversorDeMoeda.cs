namespace ExercicioFixacao {
    public static class ConversorDeMoeda {
        public static double Iof = 6.0;

        public static double Conversor(double cotacaoDolar, double valorDolar) {
            return ((valorDolar*cotacaoDolar) * Iof/100) + valorDolar * cotacaoDolar;
        }
    }
}
