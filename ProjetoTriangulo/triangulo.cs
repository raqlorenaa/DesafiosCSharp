using System;

public class Triangulo
{
    public Vertice Vertice1 { get; private set; }
    public Vertice Vertice2 { get; private set; }
    public Vertice Vertice3 { get; private set; }

    public Triangulo(Vertice v1, Vertice v2, Vertice v3)
    {
        if (!FormaTriangulo(v1, v2, v3))
        {
            throw new ArgumentException("Os vértices não formam um triângulo.");
        }

        Vertice1 = v1;
        Vertice2 = v2;
        Vertice3 = v3;
    }

    public bool Igual(Triangulo outro)
    {
        return Vertice1.Igual(outro.Vertice1) && Vertice2.Igual(outro.Vertice2) && Vertice3.Igual(outro.Vertice3);
    }

    public double Perimetro
    {
        get
        {
            return Vertice1.Distancia(Vertice2) + Vertice2.Distancia(Vertice3) + Vertice3.Distancia(Vertice1);
        }
    }

    public TipoTriangulo Tipo
    {
        get
        {
            double lado1 = Vertice1.Distancia(Vertice2);
            double lado2 = Vertice2.Distancia(Vertice3);
            double lado3 = Vertice3.Distancia(Vertice1);

            if (lado1 == lado2 && lado2 == lado3)
                return TipoTriangulo.Equilatero;
            else if (lado1 == lado2 || lado2 == lado3 || lado1 == lado3)
                return TipoTriangulo.Isosceles;
            else
                return TipoTriangulo.Escaleno;
        }
    }

    public double Area
    {
        get
        {
            double a = Vertice1.Distancia(Vertice2);
            double b = Vertice2.Distancia(Vertice3);
            double c = Vertice3.Distancia(Vertice1);
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }

    private bool FormaTriangulo(Vertice v1, Vertice v2, Vertice v3)
    {
        double lado1 = v1.Distancia(v2);
        double lado2 = v2.Distancia(v3);
        double lado3 = v3.Distancia(v1);

        return lado1 + lado2 > lado3 && lado2 + lado3 > lado1 && lado3 + lado1 > lado2;
    }
}
