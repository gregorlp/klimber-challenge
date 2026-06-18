using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [Test]
        public void TestResumenListaVacia()
        {
            Assert.That(
                FormaGeometricaImpresion.Imprimir(new List<Figura>(), 1),
                Is.EqualTo("<h1>Lista vacía de formas!</h1>"));
        }

        [Test]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.That(
                FormaGeometricaImpresion.Imprimir(new List<Figura>(), 2),
                Is.EqualTo("<h1>Empty list of shapes!</h1>"));
        }

        [Test]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<Figura>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometricaImpresion.Imprimir(formas, FormaGeometricaImpresion.Ingles);

            Assert.That(resumen, Is.EqualTo(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65"));
        }

        [Test]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<Figura>
            {
                new Cuadrado(5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m)
            };

            var resumen = FormaGeometricaImpresion.Imprimir(formas, FormaGeometricaImpresion.Castellano);

            Assert.That(resumen, Is.EqualTo(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 formas Perimetro 97.66 Area 91.65"));
        }

            }
        }
