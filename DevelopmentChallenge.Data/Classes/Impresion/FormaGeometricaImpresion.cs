/******************************************************************************************************************/
/******* ¿Qué pasa si debemos soportar un nuevo idioma para los reportes, o agregar más formas geométricas? *******/
/******************************************************************************************************************/

/*
 * TODO: 
 * Refactorizar la clase para respetar principios de la programación orientada a objetos.
 * Implementar la forma Trapecio/Rectangulo. 
 * Agregar el idioma Italiano (o el deseado) al reporte.
 * Se agradece la inclusión de nuevos tests unitarios para validar el comportamiento de la nueva funcionalidad agregada (los tests deben pasar correctamente al entregar la solución, incluso los actuales.)
 * Una vez finalizado, hay que subir el código a un repo GIT y ofrecernos la URL para que podamos utilizar la nueva versión :).
 */

using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public class FormaGeometricaImpresion
    {
        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;

        #endregion

        public static string Imprimir(List<Figura> figuras, int idioma)
        {
            var sb = new StringBuilder();

            if (!figuras.Any())
            {
                if (idioma == Castellano)
                    sb.Append("<h1>Lista vacía de formas!</h1>");
                else
                    sb.Append("<h1>Empty list of shapes!</h1>");
            }
            else
            {
                if (idioma == Castellano)
                    sb.Append("<h1>Reporte de Formas</h1>");
                else
                    sb.Append("<h1>Shapes report</h1>");

                var totalFormas    = 0;
                var totalArea      = 0m;
                var totalPerimetro = 0m;

                foreach (var grupo in figuras.GroupBy(f => f.GetType()))
                {
                    var representante = grupo.First();
                    var cantidad      = grupo.Count();
                    var area          = grupo.Sum(f => f.CalcularArea());
                    var perimetro     = grupo.Sum(f => f.CalcularPerimetro());

                    sb.Append(ObtenerLinea(cantidad, area, perimetro, representante, idioma));

                    totalFormas    += cantidad;
                    totalArea      += area;
                    totalPerimetro += perimetro;
                }

                sb.Append("TOTAL:<br/>");
                sb.Append(totalFormas + " " + (idioma == Castellano ? "formas" : "shapes") + " ");
                sb.Append((idioma == Castellano ? "Perimetro " : "Perimeter ") + totalPerimetro.ToString("#.##") + " ");
                sb.Append("Area " + totalArea.ToString("#.##"));
            }

            return sb.ToString();
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Figura figura, int idioma)
        {
            if (cantidad > 0)
            {
                if (idioma == Castellano)
                    return $"{cantidad} {figura.Descripcion(cantidad, idioma)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";

                return $"{cantidad} {figura.Descripcion(cantidad, idioma)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
            }

            return string.Empty;
        }
    }
}
