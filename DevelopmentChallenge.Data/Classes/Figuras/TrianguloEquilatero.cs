using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : Figura
    {
        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override string Descripcion(int cantidad, int idioma)
        {
            if (idioma == Castellano) return cantidad == 1 ? "Triángulo" : "Triángulos";
            else return cantidad == 1 ? "Triangle" : "Triangles";
        }
        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }
    }
}
