using MetodoAbstratoResolvido.Entities.Enums;

namespace MetodoAbstratoResolvido.Entities
{
    abstract class Shape
    {
        protected Color Color { get; set; }

        /* Se adicionar constructor base tira obrigatoriedade de criar constructor (mesmo em classe abstrata) */
         // public Shape() { }

        public Shape(Color color) { Color = color; }

        public abstract double Area();
    }
}
