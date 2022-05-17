using System;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public TrianguloEquilatero(decimal lado)
        {
            this.lado = lado;
            this.nombre = "Triangulo";
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
        }

        public override decimal CalcularPerimetro()
        {
            return lado * 3;
        }
    }
}