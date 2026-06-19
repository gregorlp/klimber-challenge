using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class RectanguloTests
    {
        [Test]
        public void TestResumenListaConUnRectanguloEnCastellano()
        {
            // Area = 4*3 = 12 | Perimetro = 2*(4+3) = 14
            var formas = new List<Figura> { new Rectangulo(4, 3) };

            var resumen = FormaGeometricaImpresion.Imprimir(formas, FormaGeometricaImpresion.Castellano);

            Assert.That(resumen, Is.EqualTo(
                "<h1>Reporte de Formas</h1>1 Rectángulo | Area 12 | Perimetro 14 <br/>TOTAL:<br/>1 formas Perimetro 14 Area 12"));
        }

        [Test]
        public void TestResumenListaConMasRectangulosEnIngles()
        {
            // Rectangulo(4,3): Area=12 | Perimetro=14
            // Rectangulo(5,2): Area=10 | Perimetro=14
            var formas = new List<Figura>
            {
                new Rectangulo(4, 3),
                new Rectangulo(5, 2)
            };

            var resumen = FormaGeometricaImpresion.Imprimir(formas, FormaGeometricaImpresion.Ingles);

            Assert.That(resumen, Is.EqualTo(
                "<h1>Shapes report</h1>2 Rectangles | Area 22 | Perimeter 28 <br/>TOTAL:<br/>2 shapes Perimeter 28 Area 22"));
        }
    }
}
