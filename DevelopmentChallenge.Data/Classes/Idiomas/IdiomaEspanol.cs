using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class IdiomaEspanol : IIdioma
    {
        private static readonly Dictionary<string, string[]> _nombres =
            new Dictionary<string, string[]>
            {
                { "cuadrado",  new[] { "Cuadrado",  "Cuadrados"  } },
                { "circulo",   new[] { "Círculo",   "Círculos"   } },
                { "triangulo", new[] { "Triángulo", "Triángulos" } },
                { "trapecio",   new[] { "Trapecio",    "Trapecios"    } },
                { "rectangulo", new[] { "Rectángulo",  "Rectángulos"  } },
            };

        public string ListaVacia()       => "<h1>Lista vacía de formas!</h1>";
        public string Encabezado()       => "<h1>Reporte de Formas</h1>";
        public string TotalFormas(int n) => $"{n} formas";
        public string LabelPerimetro()   => "Perimetro";

        public string NombreFigura(string clave, int cantidad)
            => cantidad == 1 ? _nombres[clave][0] : _nombres[clave][1];
    }
}
