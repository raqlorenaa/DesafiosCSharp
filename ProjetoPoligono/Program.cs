using System;
using System.Collections.Generic;
using shared;

class PoligonoTeste
{
    static void Main(string[] args)
    {
        List<Vertice> verticesIniciais = new List<Vertice>
        {
            new Vertice(0, 0),
            new Vertice(0, 3),
            new Vertice(4, 0)
        };

        Poligono poligono = new Poligono(verticesIniciais);
        Console.WriteLine($"Quantidade inicial de vértices: {poligono.QuantidadeVertices}");

        //adição de um novo vértice
        Vertice novoVertice = new Vertice(2, 2);
        bool adicionado = poligono.AddVertice(novoVertice);
        Console.WriteLine($"Novo vértice adicionado? {adicionado}");

        //remoção de um vértice
        poligono.RemoveVertice(novoVertice);
        Console.WriteLine($"Vértice removido. Quantidade de vértices agora: {poligono.QuantidadeVertices}");
    }
}
