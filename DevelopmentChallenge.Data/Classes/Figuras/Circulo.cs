using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : Figura
    {
        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _lado;
        }
        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * (_lado / 2) * (_lado / 2);
        }

        public override string Descripcion(int cantidad, int idioma)
        {
            if (idioma == Castellano) return cantidad == 1 ? "Círculo" : "Círculos";
            else return cantidad == 1 ? "Circle" : "Circles";
        }

        public Circulo(decimal diametro)
        {
            _lado = diametro;
        }
    }
}
