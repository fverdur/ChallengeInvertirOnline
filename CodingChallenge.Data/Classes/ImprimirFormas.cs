/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class ImprimirFormas
    {
        public ImprimirFormas()
        {
            Idioma.Textos.SetTexto("es", "ListaVacia", "<h1>Lista vacía de formas!</h1>");
            Idioma.Textos.SetTexto("en", "ListaVacia", "<h1>Empty list of shapes!</h1>");
            Idioma.Textos.SetTexto("es", "Reporte", "<h1>Reporte de Formas</h1>");
            Idioma.Textos.SetTexto("en", "Reporte", "<h1>Shapes report</h1>");
            Idioma.Textos.SetTexto("es", "Formas", "Formas");
            Idioma.Textos.SetTexto("en", "Formas", "Shapes");
            Idioma.Textos.SetTexto("es", "Perimetro", "Perimetro");
            Idioma.Textos.SetTexto("en", "Perimetro", "Perimeter");
            Idioma.Textos.SetTexto("es", "Area", "Area");
            Idioma.Textos.SetTexto("en", "Area", "Area");
            Idioma.Textos.SetTexto("es", "Circulo", "Círculo");
            Idioma.Textos.SetTexto("en", "Circulo", "Circle");
            Idioma.Textos.SetTexto("es", "Circulos", "Círculos");
            Idioma.Textos.SetTexto("en", "Circulos", "Circles");
            Idioma.Textos.SetTexto("es", "Cuadrado", "Cuadrado");
            Idioma.Textos.SetTexto("en", "Cuadrado", "Square");
            Idioma.Textos.SetTexto("es", "Cuadrados", "Cuadrados");
            Idioma.Textos.SetTexto("en", "Cuadrados", "Squares");
            Idioma.Textos.SetTexto("es", "Triangulo", "Triángulo");
            Idioma.Textos.SetTexto("en", "Triangulo", "Triangle");
            Idioma.Textos.SetTexto("es", "Triangulos", "Triángulos");
            Idioma.Textos.SetTexto("en", "Triangulos", "Triangles");
            Idioma.Textos.SetTexto("es", "Trapecio", "Trapecio");
            Idioma.Textos.SetTexto("en", "Trapecio", "Trapeze");
            Idioma.Textos.SetTexto("es", "Trapecios", "Trapecios");
            Idioma.Textos.SetTexto("en", "Trapecios", "Trapezoids");
            Idioma.Textos.SetTexto("es", "Rectangulo", "Rectángulo");
            Idioma.Textos.SetTexto("en", "Rectangulo", "Rectangle");
            Idioma.Textos.SetTexto("es", "Rectangulos", "Rectángulos");
            Idioma.Textos.SetTexto("en", "Rectangulos", "Rectangles");
        }

        public string Imprimir(List<IFormaGeometrica> formas, string idioma)
        {
            var sb = new StringBuilder();

            if (!formas.Any())
            {
                sb.Append(Idioma.Textos.GetTexto(idioma, "ListaVacia"));
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER

                sb.Append(Idioma.Textos.GetTexto(idioma, "Reporte"));

                foreach (var tipos in formas.GroupBy(g => g.nombre))
                {
                    sb.Append(ObtenerLinea(tipos.Count(), tipos.Sum(t => t.CalcularArea()), tipos.Sum(t => t.CalcularPerimetro()), tipos.First().nombre, idioma));
                }

                // FOOTER
                sb.Append("TOTAL:<br/>");
                sb.Append(formas.Count() + " " + Idioma.Textos.GetTexto(idioma, "Formas") + " ");
                sb.Append(Idioma.Textos.GetTexto(idioma, "Perimetro") + " " + formas.Sum(x => x.CalcularPerimetro()).ToString("#.##") + " ");
                sb.Append(Idioma.Textos.GetTexto(idioma, "Area") + " " + formas.Sum(x => x.CalcularArea()).ToString("#.##"));
            }

            return sb.ToString();
        }

        private string ObtenerLinea(int cantidad, decimal area, decimal perimetro, string nombre, string idioma)
        {
            return $"{cantidad} {TraducirForma(nombre, cantidad, idioma)} | {Idioma.Textos.GetTexto(idioma, "Area")} {area:#.##} | {Idioma.Textos.GetTexto(idioma, "Perimetro")} {perimetro:#.##} <br/>";
        }

        private string TraducirForma(string nombre, int cantidad, string idioma)
        {
            string plural = cantidad > 1 ? "s" : "";
            return Idioma.Textos.GetTexto(idioma, nombre + plural);
        }
    }
}