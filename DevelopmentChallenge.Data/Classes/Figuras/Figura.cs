namespace DevelopmentChallenge.Data.Classes
{
    public abstract class Figura
    {
        public decimal _lado;

        public abstract string Clave { get; }

        public string Descripcion(int cantidad, IIdioma idioma)
            => idioma.NombreFigura(Clave, cantidad);

        public virtual decimal CalcularPerimetro() => 0;
        public virtual decimal CalcularArea()      => 0;
    }
}
