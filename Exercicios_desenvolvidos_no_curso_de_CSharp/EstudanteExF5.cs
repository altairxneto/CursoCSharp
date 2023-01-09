namespace ExercicioFixacao {
    internal class EstudanteExF5 {
        public string Nome { get; set; }
        public string Email { get; set; }

        public EstudanteExF5(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return Nome + ", " + Email;
        }
    }
}
