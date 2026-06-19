namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : Figura
    {
        private readonly decimal _ancho;

        public override string Clave => "rectangulo";

        public override decimal CalcularArea()      => _lado * _ancho;
        public override decimal CalcularPerimetro() => 2 * (_lado + _ancho);

        public Rectangulo(decimal alto, decimal ancho)
        {
            _lado  = alto;
            _ancho = ancho;
        }
    }
}
