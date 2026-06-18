using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class IdiomaIngles : IIdioma
    {
        private static readonly Dictionary<string, string[]> _nombres =
            new Dictionary<string, string[]>
            {
                { "cuadrado",  new[] { "Square",    "Squares"    } },
                { "circulo",   new[] { "Circle",    "Circles"    } },
                { "triangulo", new[] { "Triangle",  "Triangles"  } },
                { "trapecio",  new[] { "Trapezoid", "Trapezoids" } },
            };

        public string ListaVacia()       => "<h1>Empty list of shapes!</h1>";
        public string Encabezado()       => "<h1>Shapes report</h1>";
        public string TotalFormas(int n) => $"{n} shapes";
        public string LabelPerimetro()   => "Perimeter";

        public string NombreFigura(string clave, int cantidad)
            => cantidad == 1 ? _nombres[clave][0] : _nombres[clave][1];
    }
}
