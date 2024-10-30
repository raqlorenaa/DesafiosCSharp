using System;

public class Vertice
{
    public double X { get; private set; }
    public double Y { get; private set; }

    public Vertice(double x, double y)
    {
        X = x;
        Y = y;
    }

    public double Distancia(Vertice outro)
    {
        return Math.Sqrt(Math.Pow(X - outro.X, 2) + Math.Pow(Y - outro.Y, 2));
    }

    public void Move(double novoX, double novoY)
    {
        X = novoX;
        Y = novoY;
    }

    public bool Igual(Vertice outro)
    {
        return X == outro.X && Y == outro.Y;
    }
}
