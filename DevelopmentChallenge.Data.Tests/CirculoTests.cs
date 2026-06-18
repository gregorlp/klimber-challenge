using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class CirculoTests
    {
        [Test]
        public void TestResumenListaConUnCirculoEnCastellano()
        {
            // Area = π*(3/2)² ≈ 7.07 | Perimetro = π*3 ≈ 9.42
            var formas = new List<Figura> { new Circulo(3) };

            var resumen = FormaGeometricaImpresion.Imprimir(formas, FormaGeometricaImpresion.Castellano);

            Assert.That(resumen, Is.EqualTo(
                "<h1>Reporte de Formas</h1>1 Círculo | Area 7.07 | Perimetro 9.42 <br/>TOTAL:<br/>1 formas Perimetro 9.42 Area 7.07"));
        }

        [Test]
        public void TestResumenListaConMasCirculosEnIngles()
        {
            // Circulo(3):    Area≈7.07  | Perimetro≈9.42
            // Circulo(2.75): Area≈5.94  | Perimetro≈8.64
            var formas = new List<Figura>
            {
                new Circulo(3),
                new Circulo(2.75m)
            };

            var resumen = FormaGeometricaImpresion.Imprimir(formas, FormaGeometricaImpresion.Ingles);

            Assert.That(resumen, Is.EqualTo(
                "<h1>Shapes report</h1>2 Circles | Area 13.01 | Perimeter 18.06 <br/>TOTAL:<br/>2 shapes Perimeter 18.06 Area 13.01"));
        }
    }
}
