using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class TrapecioTests
    {
        [Test]
        public void TestResumenListaConUnTrapecioEnCastellano()
        {
            // Area = (8+4)*3/2 = 18 | Perimetro = 8+4 + 2*sqrt(9+4) ≈ 19.21
            var formas = new List<Figura> { new Trapecio(8, 4, 3) };

            var resumen = FormaGeometricaImpresion.Imprimir(formas, FormaGeometricaImpresion.Castellano);

            Assert.That(resumen, Is.EqualTo(
                "<h1>Reporte de Formas</h1>1 Trapecio | Area 18 | Perimetro 19.21 <br/>TOTAL:<br/>1 formas Perimetro 19.21 Area 18"));
        }

        [Test]
        public void TestResumenListaConMasTrapeciosEnIngles()
        {
            // Trapecio(8,4,3): Area=18 | Perimetro≈19.21
            // Trapecio(6,2,4): Area=16 | Perimetro≈16.94
            var formas = new List<Figura>
            {
                new Trapecio(8, 4, 3),
                new Trapecio(6, 2, 4)
            };

            var resumen = FormaGeometricaImpresion.Imprimir(formas, FormaGeometricaImpresion.Ingles);

            Assert.That(resumen, Is.EqualTo(
                "<h1>Shapes report</h1>2 Trapezoids | Area 34 | Perimeter 36.16 <br/>TOTAL:<br/>2 shapes Perimeter 36.16 Area 34"));
        }
    }
}
