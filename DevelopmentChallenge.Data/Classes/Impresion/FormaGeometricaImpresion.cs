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
        #region Idiomas (backward compatibility)

        public const int Castellano = 1;
        public const int Ingles     = 2;

        #endregion

        public static string Imprimir(List<Figura> figuras, IIdioma idioma)
        {
            var sb = new StringBuilder();

            if (!figuras.Any())
            {
                sb.Append(idioma.ListaVacia());
            }
            else
            {
                sb.Append(idioma.Encabezado());

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
                sb.Append(idioma.TotalFormas(totalFormas) + " ");
                sb.Append(idioma.LabelPerimetro() + " " + totalPerimetro.ToString("#.##") + " ");
                sb.Append("Area " + totalArea.ToString("#.##"));
            }

            return sb.ToString();
        }

        public static string Imprimir(List<Figura> figuras, int idioma)
        {
            IIdioma lang = idioma == Castellano
                ? (IIdioma)new IdiomaEspanol()
                : new IdiomaIngles();

            return Imprimir(figuras, lang);
        }

        private static string ObtenerLinea(int cantidad, decimal area, decimal perimetro, Figura figura, IIdioma idioma)
        {
            if (cantidad > 0)
                return $"{cantidad} {figura.Descripcion(cantidad, idioma)} | Area {area:#.##} | {idioma.LabelPerimetro()} {perimetro:#.##} <br/>";

            return string.Empty;
        }
    }
}
