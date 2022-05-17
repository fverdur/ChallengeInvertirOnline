using System;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        public Circulo(decimal lado)
        {
            this.lado = lado;
            this.nombre = "Circulo";
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (lado / 2) * (lado / 2);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * lado;
        }
    }
}