using System.Collections.Generic;

namespace DevelopmentChallenge.Data.Classes
{
    public class IdiomaItaliano : IIdioma
    {
        private static readonly Dictionary<string, string[]> _nombres =
            new Dictionary<string, string[]>
            {
                { "cuadrado",  new[] { "Quadrato",  "Quadrati"  } },
                { "circulo",   new[] { "Cerchio",   "Cerchi"    } },
                { "triangulo", new[] { "Triangolo", "Triangoli" } },
                { "trapecio",   new[] { "Trapezio",   "Trapezi"    } },
                { "rectangulo", new[] { "Rettangolo", "Rettangoli" } },
            };

        public string ListaVacia()       => "<h1>Elenco di forme vuoto!</h1>";
        public string Encabezado()       => "<h1>Rapporto sulle forme</h1>";
        public string TotalFormas(int n) => $"{n} forme";
        public string LabelPerimetro()   => "Perimetro";

        public string NombreFigura(string clave, int cantidad)
            => cantidad == 1 ? _nombres[clave][0] : _nombres[clave][1];
    }
}
