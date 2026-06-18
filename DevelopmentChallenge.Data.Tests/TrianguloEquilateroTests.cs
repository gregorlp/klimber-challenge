using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class TrianguloEquilateroTests
    {
        [Test]
        public void TestResumenListaConUnTrianguloEnCastellano()
        {
            // Area = (√3/4)*4² ≈ 6.93 | Perimetro = 4*3 = 12
            var formas = new List<Figura> { new TrianguloEquilatero(4) };

            var resumen = FormaGeometricaImpresion.Imprimir(formas, FormaGeometricaImpresion.Castellano);

            Assert.That(resumen, Is.EqualTo(
                "<h1>Reporte de Formas</h1>1 Triángulo | Area 6.93 | Perimetro 12 <br/>TOTAL:<br/>1 formas Perimetro 12 Area 6.93"));
        }

        [Test]
        public void TestResumenListaConMasTriangulosEnIngles()
        {
            // TrianguloEquilatero(4):   Area≈6.93  | Perimetro=12
            // TrianguloEquilatero(9):   Area≈35.07 | Perimetro=27
            // TrianguloEquilatero(4.2): Area≈7.64  | Perimetro=12.6
            var formas = new List<Figura>
            {
                new TrianguloEquilatero(4),
                new TrianguloEquilatero(9),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometricaImpresion.Imprimir(formas, FormaGeometricaImpresion.Ingles);

            Assert.That(resumen, Is.EqualTo(
                "<h1>Shapes report</h1>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>3 shapes Perimeter 51.6 Area 49.64"));
        }
    }
}
