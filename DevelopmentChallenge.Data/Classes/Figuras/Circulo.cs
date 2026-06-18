using System;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : Figura
    {
        public override string Clave => "circulo";

        public override decimal CalcularPerimetro() => (decimal)Math.PI * _lado;
        public override decimal CalcularArea()      => (decimal)Math.PI * (_lado / 2) * (_lado / 2);

        public Circulo(decimal diametro)
        {
            _lado = diametro;
        }
    }
}
