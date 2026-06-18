using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class IdiomaItalianoTests
    {
        private static readonly IIdioma Italiano = new IdiomaItaliano();

        [Test]
        public void TestListaVaciaEnItaliano()
        {
            Assert.That(
                FormaGeometricaImpresion.Imprimir(new List<Figura>(), Italiano),
                Is.EqualTo("<h1>Elenco di forme vuoto!</h1>"));
        }

        [Test]
        public void TestUnCuadradoEnItaliano()
        {
            var formas = new List<Figura> { new Cuadrado(5) };

            Assert.That(
                FormaGeometricaImpresion.Imprimir(formas, Italiano),
                Is.EqualTo("<h1>Rapporto sulle forme</h1>1 Quadrato | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forme Perimetro 20 Area 25"));
        }

        [Test]
        public void TestMasFigurasEnItaliano()
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

            Assert.That(
                FormaGeometricaImpresion.Imprimir(formas, Italiano),
                Is.EqualTo("<h1>Rapporto sulle forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Cerchi | Area 13.01 | Perimetro 18.06 <br/>3 Triangoli | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 forme Perimetro 97.66 Area 91.65"));
        }
    }
}
