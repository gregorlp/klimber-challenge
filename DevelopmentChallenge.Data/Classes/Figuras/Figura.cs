using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class Figura
    {
        public decimal _lado;

        #region Idiomas

        public const int Castellano = 1;
        public const int Ingles = 2;

        #endregion

        public virtual string Descripcion(int cantidad, int idioma)
        {
            return string.Empty;
        }

        public virtual decimal CalcularPerimetro()
        {
            return 0;
        }

        public virtual decimal CalcularArea()
        {
            return 0;
        }
    }
}
