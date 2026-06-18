using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Trapecio : Figura
    {
        private readonly decimal _baseMayor;
        private readonly decimal _baseMenor;
        private readonly decimal _altura;

        public override string Clave => "trapecio";

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura)
        {
            _baseMayor = baseMayor;
            _baseMenor = baseMenor;
            _altura    = altura;
        }

        public override decimal CalcularArea()
            => (_baseMayor + _baseMenor) * _altura / 2;

        public override decimal CalcularPerimetro()
        {
            var ladoLateral = (decimal)Math.Sqrt(
                Math.Pow((double)_altura, 2) +
                Math.Pow((double)((_baseMayor - _baseMenor) / 2), 2));

            return _baseMayor + _baseMenor + 2 * ladoLateral;
        }
    }
}
