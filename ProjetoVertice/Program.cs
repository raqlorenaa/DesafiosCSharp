using System;

class Program
{
    static void Main(string[] args)
    {
        
        Vertice vertice1 = new Vertice(1.0, 2.0);
        Vertice vertice2 = new Vertice(4.0, 6.0);

        
        double distancia = vertice1.Distancia(vertice2);
        Console.WriteLine($"Distância entre vertice1 e vertice2: {distancia}");

        
        vertice1.Move(2.0, 3.0);
        Console.WriteLine($"Nova posição do vertice1: ({vertice1.X}, {vertice1.Y})");

        
        bool saoIguais = vertice1.Igual(vertice2);
        Console.WriteLine($"Vertice1 e vertice2 são iguais? {saoIguais}");
        
        
        vertice2.Move(2.0, 3.0);
        saoIguais = vertice1.Igual(vertice2);
        Console.WriteLine($"Vertice1 e vertice2 são iguais agora? {saoIguais}");
    }
}
