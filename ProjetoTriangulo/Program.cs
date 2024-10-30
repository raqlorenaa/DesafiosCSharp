using System;

class Program
{
    static void Main(string[] args)
    {
        Vertice v1 = new Vertice(0, 0);
        Vertice v2 = new Vertice(0, 3);
        Vertice v3 = new Vertice(4, 0);

        try
        {
            Triangulo triangulo = new Triangulo(v1, v2, v3);
            Console.WriteLine($"Perímetro: {triangulo.Perimetro}");
            Console.WriteLine($"Área: {triangulo.Area}");
            Console.WriteLine($"Tipo: {triangulo.Tipo}");

            Vertice v4 = new Vertice(0, 0);
            Vertice v5 = new Vertice(0, 3);
            Vertice v6 = new Vertice(4, 0);
            Triangulo outroTriangulo = new Triangulo(v4, v5, v6);

            Console.WriteLine($"Triângulos iguais? {triangulo.Igual(outroTriangulo)}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
