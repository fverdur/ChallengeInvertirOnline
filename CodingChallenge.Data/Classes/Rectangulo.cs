namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        #region propiedades

        public decimal altura { get; set; }

        #endregion propiedades

        public Rectangulo(decimal lado, decimal altura)
        {
            this.lado = lado;
            this.altura = altura;
            this.nombre = "Rectangulo";
        }

        public override decimal CalcularArea()
        {
            return (lado * 2) + (altura * 2);
        }

        public override decimal CalcularPerimetro()
        {
            return lado * altura;
        }
    }
}