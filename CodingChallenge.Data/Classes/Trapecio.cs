using System;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : FormaGeometrica
    {
        #region propiedades

        public decimal baseMayor { get; set; }
        public decimal baseMenor { get; set; }

        #endregion propiedades

        public Trapecio(decimal lado, decimal basemayor, decimal basemenor)
        {
            this.lado = lado;
            this.baseMayor = basemayor;
            this.baseMenor = basemenor;
            this.nombre = "Trapecio";
        }

        public override decimal CalcularArea()
        {
            decimal baseTriangulo = (baseMayor - baseMenor) / 2;
            decimal altura = Convert.ToDecimal(Math.Sqrt(Convert.ToDouble(lado * lado - baseTriangulo * baseTriangulo)));
            return ((baseMayor + baseMenor) / 2) * altura;
        }

        public override decimal CalcularPerimetro()
        {
            return baseMenor + baseMayor + (lado * 2);
        }
    }
}