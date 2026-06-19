# Development Challenge - Klimber

![CI](https://github.com/gregorlp/klimber-challenge/actions/workflows/ci.yml/badge.svg)

Refactorización de un módulo de reporte de formas geométricas, aplicando principios de OOP y el patrón Strategy para soportar múltiples idiomas y formas de forma extensible.

## Qué se hizo

El código original tenía toda la lógica en una única clase monolítica (`FormaGeometrica`), con `if/else` para cada idioma y cada forma. Agregar un nuevo idioma o figura requería modificar múltiples archivos.

### Cambios principales

- **Patrón Strategy para idiomas**: se creó la interfaz `IIdioma` con implementaciones `IdiomaEspanol`, `IdiomaIngles` e `IdiomaItaliano`. Agregar un nuevo idioma es crear una sola clase nueva sin tocar nada existente (**Open/Closed Principle**).
- **Herencia para figuras**: clase abstracta `Figura` con `CalcularArea()`, `CalcularPerimetro()` y `Clave`. Cada figura solo define su propia lógica.
- **Trapecio**: implementado como trapecio isósceles con sus fórmulas de área y perímetro.
- **Idioma Italiano**: incorporado como nuevo idioma de ejemplo.
- **Tests por figura**: se agregaron tests unitarios separados por figura y por idioma.

### Estructura

```
DevelopmentChallenge.Data
??? Classes
?   ??? Figuras
?   ?   ??? Figura.cs          ? clase base abstracta
?   ?   ??? Cuadrado.cs
?   ?   ??? Circulo.cs
?   ?   ??? TrianguloEquilatero.cs
?   ?   ??? Trapecio.cs
?   ??? Idiomas
?   ?   ??? IIdioma.cs         ? interfaz Strategy
?   ?   ??? IdiomaEspanol.cs
?   ?   ??? IdiomaIngles.cs
?   ?   ??? IdiomaItaliano.cs
?   ??? Impresion
?       ??? FormaGeometricaImpresion.cs

DevelopmentChallenge.Data.Tests
??? CuadradoTests.cs
??? CirculoTests.cs
??? TrianguloEquilateroTests.cs
??? TrapecioTests.cs
??? IdiomaItalianoTests.cs
??? DataTests.cs
```

## Cómo correr los tests

### Requisitos
- Visual Studio 2019+
- .NET Framework 4.6.2

### Pasos

```bash
# Restaurar paquetes
nuget restore DevelopmentChallenge.sln

# Compilar
msbuild DevelopmentChallenge.sln /p:Configuration=Release

# Ejecutar tests
.\packages\NUnit.ConsoleRunner.3.22.0\tools\nunit3-console.exe DevelopmentChallenge.Data.Tests\bin\Release\DevelopmentChallenge.Data.Tests.dll
```

O simplemente desde Visual Studio: **Test ? Run All Tests**.

## Cómo agregar un nuevo idioma

1. Crear una clase que implemente `IIdioma`:

```csharp
public class IdiomaFrances : IIdioma
{
    public string ListaVacia()       => "<h1>Liste de formes vide!</h1>";
    public string Encabezado()       => "<h1>Rapport des formes</h1>";
    public string TotalFormas(int n) => $"{n} formes";
    public string LabelPerimetro()   => "Périmètre";

    public string NombreFigura(string clave, int cantidad) { ... }
}
```

2. Usarlo:

```csharp
FormaGeometricaImpresion.Imprimir(figuras, new IdiomaFrances());
```

No hay que modificar ninguna clase existente.
