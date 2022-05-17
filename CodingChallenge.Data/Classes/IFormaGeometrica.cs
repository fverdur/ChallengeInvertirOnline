namespace CodingChallenge.Data.Classes
{
    public interface IFormaGeometrica
    {
        string nombre { get; set; }

        decimal CalcularArea();

        decimal CalcularPerimetro();
    }
}