using System;

namespace CodingChallenge.Data.Classes
{
    public abstract class FormaGeometrica : IFormaGeometrica
    {
        #region propiedades

        public string nombre { get; set; }
        protected decimal lado { get; set; }

        #endregion propiedades

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();                
    }
}