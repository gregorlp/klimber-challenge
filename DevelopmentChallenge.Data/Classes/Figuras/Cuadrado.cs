namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : Figura
    {
        public override string Clave => "cuadrado";

        public override decimal CalcularPerimetro() => _lado * 4;
        public override decimal CalcularArea()      => _lado * _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }
    }
}
