using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : Figura
    {
        public override string Clave => "triangulo";

        public override decimal CalcularPerimetro() => _lado * 3;
        public override decimal CalcularArea()      => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }
    }
}
