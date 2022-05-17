using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            ImprimirFormas imprimir = new ImprimirFormas();
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                imprimir.Imprimir(new List<IFormaGeometrica>(), "es"));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            ImprimirFormas imprimir = new ImprimirFormas();
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                imprimir .Imprimir(new List<IFormaGeometrica>(), "en"));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            ImprimirFormas imprimir = new ImprimirFormas();
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };

            var resumen = imprimir.Imprimir(cuadrados, "es");

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 Formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            ImprimirFormas imprimir = new ImprimirFormas();
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = imprimir.Imprimir(cuadrados, "en");

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 Shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            ImprimirFormas imprimir = new ImprimirFormas();
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Rectangulo(7,5),
                new Trapecio(5,9,3),
                new Cuadrado(2),
                new TrianguloEquilatero(9),                
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Rectangulo(5,3),
                new Trapecio(3,8,3)
            };

            
            var resumen = imprimir.Imprimir(formas, "en");

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>2 Rectangles | Area 40 | Perimeter 50 <br/>2 Trapezoids | Area 33,12 | Perimeter 39 <br/>TOTAL:<br/>11 Shapes Perimeter 186,66 Area 164,77",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            ImprimirFormas imprimir = new ImprimirFormas();
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Rectangulo(7,5),
                new Trapecio(5,9,3),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m),
                new Rectangulo(5,3),
                new Trapecio(3,8,3)
            };

            var resumen = imprimir.Imprimir(formas, "es");

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>2 Rectángulos | Area 40 | Perimetro 50 <br/>2 Trapecios | Area 33,12 | Perimetro 39 <br/>TOTAL:<br/>11 Formas Perimetro 186,66 Area 164,77",
                resumen);
        }
    }
}