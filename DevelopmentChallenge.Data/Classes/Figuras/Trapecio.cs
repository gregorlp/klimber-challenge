using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : Figura
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura    = altura;
        }

        public override decimal CalcularArea()
        {
            return (_baseMayor + _baseMenor) * _altura / 2;
        }

        public override decimal CalcularPerimetro()
        {
            // Trapecio isósceles: lados laterales iguales
            var ladoLateral = (decimal)Math.Sqrt(
                Math.Pow((double)_altura, 2) +
                Math.Pow((double)((_baseMayor - _baseMenor) / 2), 2));

            return _baseMayor + _baseMenor + 2 * ladoLateral;
        }

        public override string Descripcion(int cantidad, int idioma)
        {
            if (idioma == Castellano) return cantidad == 1 ? "Trapecio" : "Trapecios";
            else return cantidad == 1 ? "Trapezoid" : "Trapezoids";
        }
    }
}
