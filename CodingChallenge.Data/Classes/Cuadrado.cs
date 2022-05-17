namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica
    {
        public Cuadrado(decimal lado)
        {
            this.lado = lado;
            this.nombre = "Cuadrado";
        }

        public override decimal CalcularArea()
        {
            return lado * lado;
        }

        public override decimal CalcularPerimetro()
        {
            return lado * 4;
        }
    }
}