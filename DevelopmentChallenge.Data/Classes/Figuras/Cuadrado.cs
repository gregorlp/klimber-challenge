using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : Figura
    {
        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override string Descripcion(int cantidad, int idioma)
        {
            if (idioma == Castellano) return cantidad == 1 ? "Cuadrado" : "Cuadrados";
            else return cantidad == 1 ? "Square" : "Squares";
        }

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }
    }
}
