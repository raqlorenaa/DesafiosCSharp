using System;
using System.Collections.Generic;
using shared;

public class Poligono
{
    private List<Vertice> vertices;

    public Poligono(List<Vertice> verticesIniciais)
    {
        if (verticesIniciais.Count < 3)
        {
            throw new ArgumentException("Um polígono deve ter pelo menos 3 vértices.");
        }
        vertices = new List<Vertice>(verticesIniciais);
    }

    public bool AddVertice(Vertice v)
    {
        foreach (var vertice in vertices)
        {
            if (vertice.Igual(v))
            {
                return false;
            }
        }
        vertices.Add(v);
        return true;
    }

    public void RemoveVertice(Vertice v)
    {
        if (vertices.Count <= 3)
        {
            throw new InvalidOperationException("O polígono deve ter pelo menos 3 vértices.");
        }
        vertices.Remove(v);
    }

    public double Perimetro
    {
        get
        {
            double perimetro = 0;
            for (int i = 0; i < vertices.Count; i++)
            {
                Vertice atual = vertices[i];
                Vertice proximo = vertices[(i + 1) % vertices.Count];
                perimetro += atual.Distancia(proximo);
            }
            return perimetro;
        }
    }

    public int QuantidadeVertices
    {
        get
        {
            return vertices.Count;
        }
    }
}
