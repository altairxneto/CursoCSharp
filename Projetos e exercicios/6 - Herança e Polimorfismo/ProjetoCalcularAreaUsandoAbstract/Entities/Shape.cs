using ProjetoCalcularAreaUsandoAbstract.Entities.Enums;

namespace ProjetoCalcularAreaUsandoAbstract.Entities {
    abstract class Shape {
        public Color Color { get; set; }

        public Shape(Color color) {
            Color = color;
        }

        public abstract double Area();
    }
}
